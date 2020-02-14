using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmDatabaseList : Form
    {
        private string frm_pathBak;
        private string frm_pathFolder;
        private string frm_pathResults;
        private int success;
        private int fail;
        private int progress;
        private InfoLogin infoLogin;
        private List<Script> frm_listScript;
        private List<Result> frm_resultList;
        private frmActionState frm_actionSate;
        private List<InfoDB> frm_listDB;
        //Server=myServerName\myInstanceName;Database=myDataBase;
        private static string[] attConnect = { "Server=", ";Database=", ";User ID=", ";Password="};
        public frmDatabaseList(InfoLogin info)
        {
            InitializeComponent();
            infoLogin = new InfoLogin(info.Machine, info.SeverName, info.User, info.Password);
            frm_GetListDB();
            frm_resultList = new List<Result>();
        }

        
        #region "Function"
        // Handle Script
        private string MakeScript(List<string> filesName)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string file in filesName)
            {
                string script = File.ReadAllText(file);
                builder.AppendLine(script);
            }
            return builder.ToString();
        }
        //Filter sql file to assure only file sql are chosen
        private List<string> FileFilter(string path)
        {
            var needFiles = from file in Directory.EnumerateFiles(path)
                            let extension = Path.GetExtension(file)
                            where extension.Equals(".sql")
                            select file;
            return needFiles.ToList();
        }
        //Parent Folder contain only child folders which each store just sql file
        private void AddFolder(string path)
        {
            try
            {
                //Case Folder version
                if (Directory.GetDirectories(path).Length > 0)
                {
                    //Extract setting default folder choose and its order
                    string[] orderScript = Properties.Settings.Default.order_folder.Split(':');
                    foreach (string order in orderScript)
                    {
                        string pathFolder = frm_pathFolder + @"\" + order;
                        //Check if exist then get all files
                        if (Directory.Exists(pathFolder))
                        {
                            var filesScript = FileFilter(pathFolder);
                            GetScript(filesScript);
                        }
                    }
                }
                else //Case Folder script
                {
                    var scripts = FileFilter(path);
                    GetScript(scripts);
                }
                
                if (frm_listScript.Count > 0)
                { MessageBox.Show("Thêm script thành công"); }
                else
                { MessageBox.Show("Thư mục rỗng"); }
            }
            catch (Exception ex) { throw ex; }            
        }        
        private void GetScript(List<string> files)
        {
            Cursor.Current = Cursors.WaitCursor;
            Script script = new Script();
            script.Query = MakeScript(files);
            string scriptName = Path.GetDirectoryName(files[0]);
            script.Folder = new DirectoryInfo(scriptName).Name;
            frm_listScript.Add(script);
            Cursor.Current = Cursors.Default;
        }
        
        //Get List DBInfo
        private List<InfoDB> GetDBs(InfoLogin infoLogin)
        {
            List<InfoDB> list = new List<InfoDB>();
            var monitoring_db = Properties.Settings.Default.default_monitoring_dbname;
            string connectString = attConnect[0] + infoLogin.Machine +
                                    attConnect[2] + infoLogin.User +
                                    attConnect[3] + infoLogin.Password;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                string query = String.Format(
                    @"SELECT s.datasource, ds.[catalog] , d.createdDate, d.brandname, d.domainname, s.[user],s.password
                        FROM	[{0}].[dbo].[storage] as s,
                                [{0}].[dbo].[domain_storage] as ds,                            
                                [{0}].[dbo].[domain] as d
                        WHERE S.ID = DS.storageid AND d.ID = ds.domainid AND s.[user] = '{1}'; ", monitoring_db, infoLogin.User);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dbList = cmd.ExecuteReader())
                    {
                        while (dbList.Read())
                        {
                            InfoDB dB = new InfoDB();
                            dB.DataSource = dbList["datasource"].ToString();
                            dB.Catalog = dbList["catalog"].ToString();
                            dB.CreatedDate = dbList["createdDate"].ToString();
                            dB.BrandName = dbList["brandName"].ToString();
                            dB.DomainName = dbList["domainName"].ToString();
                            dB.User = dbList["user"].ToString();
                            dB.Password = dbList["password"].ToString();
                            dB.UpdateChoice = false;
                            list.Add(dB);
                        }
                    }
                }
            }
            return list;
        }
        private void frm_GetListDB()
        {
            frm_listDB = GetDBs(infoLogin);
            gvDBList.DataSource = frm_listDB;
        }
        //Upgrade
        private void UpgradeDB(InfoDB db)
        {
            string connectString = attConnect[0] + db.DataSource +
                                    attConnect[1] + db.Catalog +
                                    attConnect[2] + db.User +
                                    attConnect[3] + db.Password;
            progress++;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                //Back up
                string resultBackUp = BackUp(connection, db.Catalog);
                //Back up if success backup
                if (resultBackUp == null)
                {
                    Result progress = new Result(resultBackUp, db.DataSource, db.Catalog);

                    ServerConnection svrConnection = new ServerConnection(connection);
                    Server server = new Server(svrConnection);
                    server.ConnectionContext.StatementTimeout = 60 * 60; //To Avoid TimeOut Exception
                    server.ConnectionContext.BeginTransaction();

                    bool stateUpgrade = true; //Commit script
                    bool isPerfect = true; //Could apply all script for database

                    foreach (Script item in frm_listScript)
                    {
                        try
                        {
                            server.ConnectionContext.ExecuteNonQuery(item.Query);
                        }
                        catch (ExecutionFailureException ex)
                        {
                            isPerfect = false;
                            Exception exception = ex.GetBaseException();
                            bool isContinue = false;
                            string errorHeader = "\n" + item.Folder + " error:\n";                            
                            string errorDetail = errorHeader + exception.ToString();
                            server.ConnectionContext.RollBackTransaction();
                            //If folder Tables error then continue
                            //For the other roll back and stop immediately
                            if (item.Folder.Equals("Tables"))
                            {
                                isContinue = true;
                            }
                            
                            //Make log result
                            progress.note = new StringBuilder(progress.note).AppendLine(errorDetail).ToString();                                                     

                            if (!isContinue) // Stop Upgrade immediately
                            {
                                progress.Folder = item.Folder;
                                string errorSummary = errorHeader + exception.Message;
                                progress.ResultUpgrade = exception.Message;                                
                                stateUpgrade = false;
                                fail++;
                                break;
                            }
                        } //End execute a folder script
                    }//End upgrade

                    if (stateUpgrade) //Upgrade success
                    {
                        server.ConnectionContext.CommitTransaction();                        
                        progress.ResultUpgrade = "";                        						
                        success++;						
                    }
                    frm_resultList.Add(progress);

                    if (!isPerfect)
                    {
                        LogError(progress);
                    }                    
                }
                else //Case Backup false
                {
                    frm_resultList.Add(new Result(resultBackUp, db));
                    fail++;
                }				
            }
        }
        private void ListScript()
        {
            string time = DateTime.Now.ToString("yyyyMMdd_");
            foreach (var item in frm_listScript)
            {
                string name = frm_pathResults + @"\" + time + item.Folder + ".sql";
                if (!File.Exists(name))
                {
                    File.WriteAllText(name, item.Query);
                }
            }
        }
        private void LogError(Result result)
        {
            string time = DateTime.Now.ToString("yyyyMMdd_hhmm");
            string errorAt = result.Folder == null? "C2714_" : ("Fail_" + result.Folder + "_");			
            string fileLog = frm_pathResults + @"\" + time + "_" + errorAt + result.Catalog + ".txt";
            string error = result.ResultUpgrade + "\n" + result.note;
            try
            {
                if (!File.Exists(fileLog))
                {
                    File.WriteAllText(fileLog, error, Encoding.Unicode);
                }
            } catch (Exception ex) { throw ex; }			
        }
        private void frm_Upgrade()
        {
            if (frm_listScript.Count == 0)
            {
                AddFolder(frm_pathFolder);
                lbNoScript.Text = "Number Script: " + frm_listScript.Count;
                ListScript();
            }
            if (frm_listScript.Count == 0) //Check if folder is empty
            {
                MessageBox.Show("Thư mục rỗng.");
                return;
            }

            var listUpgrade = ListUseDB();
            if (listUpgrade.Count > 0)
            {
                frm_resultList = new List<Result>();
                int maxTask = Properties.Settings.Default.maxTask;
                int totalWork = listUpgrade.Count();
                ResetWorkingState(totalWork);
                foreach (InfoDB item in listUpgrade)
                {
                    UpgradeDB(item);
                }
                DisplayState(totalWork);
                ShowFrmActionState(frm_resultList);
                return;
            }
            MessageBox.Show("Vui lòng chọn Database để nâng cấp.");
        }
        private void FolderResult()
        {
            try
            {
                if (frm_resultList.Exists(result =>
                    (!result.ResultUpgrade.Equals("")) || (!result.Equals("Success"))))
                {
                    var psi = new ProcessStartInfo();
                    psi.FileName = "explorer.exe";
                    psi.UseShellExecute = false;
                    psi.RedirectStandardOutput = false;
                    psi.Arguments = frm_pathResults;
                    Process.Start(psi);
                }
                else
                    MessageBox.Show("Không có lỗi");
            } catch (Exception ex) { throw ex; }				
        }
        private string BackUp(SqlConnection connection, string dbName)
        {
            try
            {
                connection.Open();
                string time = DateTime.Now.ToString("_ddMMyyyy_hhmm");
                string filePath = frm_pathBak + @"\" + dbName + time + ".bak";
                string testQuery = "BACKUP DATABASE " + dbName + " TO DISK = '" + filePath + "'";				
                using (SqlCommand command = new SqlCommand(testQuery, connection))
                {
                    command.CommandTimeout = 60 * 60;
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)	{ return ex.Message; }
                    finally { connection.Close(); }
                }
            }
            catch (SqlException ex)
            {
                return ex.Message;				
            }			
            return null;
        }
        private List<InfoDB> ListUseDB()
        {
            var listUse = frm_listDB.FindAll(sDB => sDB.UpdateChoice == true);
            return listUse;
        }
        private void ShowFrmActionState(List<Result> resultAction)
        {
            frm_actionSate = new frmActionState(resultAction);
            frm_actionSate.Show();
            if (frm_resultList.Exists(r =>
                        (!r.ResultUpgrade.Equals("Success")) ||
                        (!r.BackupResult.Equals("Done")) ||
                        (!r.Note.Equals(""))))
            {
                DialogResult dialogResult = MessageBox.Show("Xem kết quả?", "Upgrade Database lỗi!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    FolderResult();
                }
            }
        }
        private void ResetWorkingState(int totalWork)
        {
            fail = 0;
            success = 0;
            progress = 0;
            lbStatAction.Text = "Running...";			
            lbSuccess.Text = "Success: " + success;
            lbFail.Text = "Fail: " + fail;
            lbTotalWork.Text = "Working: " + progress + @"/" + totalWork;
            pLoading.Visible = true;
            Cursor.Current = Cursors.WaitCursor;
        }
        private void DisplayState(int totalWork)
        {
            while ((fail + success) < totalWork)
            {
                Thread.Sleep(100);
                lbSuccess.Refresh();
                lbFail.Refresh();
                lbTotalWork.Refresh();
            }
            lbSuccess.Text = "Success: " + success;
            lbFail.Text = "Fail: " + fail;
            lbTotalWork.Text = "Working: " + progress + @"/" + totalWork;
            lbStatAction.Text = "Done";			
            pLoading.Visible = false;
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Công việc hoàn tất.");
        }
        private void CountCheck()
        {
            var count = frm_listDB.FindAll(db => db.UpdateChoice == true).Count;
            lbCountDBSelected.Text = "Count: " + count;
        }
        #endregion

        #region "Event"
        private void frmDatabaseList_Load(object sender, EventArgs e)
        {
            //Initialize workshop
            frm_listScript = new List<Script>();            
            frm_pathFolder = Properties.Settings.Default.default_script_directory;			
            lbFolderPath.Text = "Folder Path: " + frm_pathFolder;
            lbNoScript.Text = "Number Script: " + frm_listScript.Count();
            pLoading.Visible = false;

            //Make folder Backup, Results
            frm_pathBak = Directory.GetCurrentDirectory() + @"\Backup";
            if (!Directory.Exists(frm_pathBak))
            {
                Directory.CreateDirectory(frm_pathBak);
            }
            lbFolderBackup.Text = "Folder Backup: " + frm_pathBak;

            frm_pathResults = Directory.GetCurrentDirectory() + @"\Results";
            if (!Directory.Exists(frm_pathResults))
            {
                Directory.CreateDirectory(frm_pathResults);
            }  
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {			
            frm_Upgrade();
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            frm_GetListDB();
        }		
        //Browse folder version or script
        private void BtnBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = frm_pathFolder;
            folderBrowser.ShowNewFolderButton = false;
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    frm_pathFolder = folderBrowser.SelectedPath;
                    Properties.Settings.Default.default_script_directory = frm_pathFolder;
                    Properties.Settings.Default.Save();
                    lbFolderPath.Text = "Folder Path: " + frm_pathFolder;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        //Right Click event in Form
        #region "Right click"
        private void upgradeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Upgrade();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_GetListDB();
            }
            catch (Exception ex) { throw ex; }
        }
        private void cmsClearScript_Click(object sender, EventArgs e)
        {
            frm_listScript = new List<Script>();			
            lbNoScript.Text = "Number Script: 0";
            MessageBox.Show("Đã làm mới script");
        }
        private void tsmbBackup_Click(object sender, EventArgs e)
        {
            frm_resultList = new List<Result>();
            try
            {
                var listBak = ListUseDB();
                foreach (InfoDB db in listBak)
                {
                    string connectString = attConnect[0] + db.DataSource +
                                            attConnect[2] + db.User +
                                            attConnect[3] + db.Password;
                    using (SqlConnection connection = new SqlConnection(connectString))
                    {
                        string result = BackUp(connection, db.Catalog);
                        frm_resultList.Add(new Result(result, db));
                    }
                    ShowFrmActionState(frm_resultList);
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void BtnCheckAll_Click(object sender, EventArgs e)
        {
            if (BtnCheckAll.Text.Equals("Check All"))
            {
                foreach (var item in frm_listDB)
                {
                    item.UpdateChoice = true;
                }
                BtnCheckAll.Text = "Uncheck All";
            }
            else
            {
                foreach (var item in frm_listDB)
                {
                    item.UpdateChoice = false;
                }
                BtnCheckAll.Text = "Check All";
            }
            CountCheck();			
            gvDBList.Refresh();
        }

        private void cmsResult_Click(object sender, EventArgs e)
        {
            if (frm_resultList.Count == 0)
            {
                MessageBox.Show("Chưa có công việc nào được thực hiện");
                return;
            }
            ShowFrmActionState(frm_resultList);
        }
        private void gvDBList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gvDBList.EndEdit();
            CountCheck();
        }

        private void frmDatabaseList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MdiParent.Refresh();
            frmMain main = (frmMain)MdiParent;
            main.Login();
        }
        private void cmsLogError_Click(object sender, EventArgs e)
        {
            FolderResult();
        }
        private void Find_txt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Regex regex = new Regex(Find_txt.Text);
                    switch (cmbFind.SelectedIndex)
                    {
                        case 0:
                            gvDBList.DataSource = frm_listDB.Where(item => regex.IsMatch(item.DataSource)).ToList();
                            break;
                        case 1:
                            gvDBList.DataSource = frm_listDB.Where(item => regex.IsMatch(item.Catalog)).ToList();
                            break;
                        case 2:
                            gvDBList.DataSource = frm_listDB.Where(item => regex.IsMatch(item.CreatedDate)).ToList();
                            break;
                        case 3:
                            gvDBList.DataSource = frm_listDB.Where(item => regex.IsMatch(item.DomainName)).ToList();
                            break;
                        case 4:
                            gvDBList.DataSource = frm_listDB.Where(item => regex.IsMatch(item.BrandName)).ToList();
                            break;
                        default:
                            gvDBList.DataSource = frm_listDB;
                            break;
                    }
                }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion

        #endregion

    }
}
