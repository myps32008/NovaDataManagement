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
using System.Windows.Forms;
using System.Configuration;

namespace NovaDataManagement
{
    public partial class frmDatabaseList : Form
    {
        private InfoLogin infoLogin;
        private List<Script> frm_listScript;        
        private List<Result> frm_resultList;
        private frmUpgradeState frmUpgrade;
        private static string[] attConnect = {  "Data Source=",
                                                ";Initial Catalog=" ,
                                                ";Persist Security Info=True;User ID=",
                                                ";Password="};

        public frmDatabaseList(string machine, string instanceSV, string user, string password)
        {
            frm_listScript = new List<Script>();
            infoLogin = new InfoLogin(machine, instanceSV, user, password);
            InitializeComponent();
        }

        #region "Event"
        private void frmDatabaseList_Load(object sender, EventArgs e)
        {
            try
            {
                frm_GetListDB();
            }
            catch (Exception bl)
            {
                throw bl;
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
        //Add/Clear Script
        #region "Handle Script"
        private void btnClearListScript_Click(object sender, EventArgs e)
        {
            frm_listScript = new List<Script>();
            this.lbFolderPath.Text = "Folder Path:";
        }
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"C:\Users\Admin\Documents";
            folderBrowser.ShowNewFolderButton = false;
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowser.SelectedPath;
                    AddFolder(path);
                    this.lbFolderPath.Text = "Folder Path: " + path;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = @"C:\Users\Admin\Desktop\Download\Test";
            openFile.Title = "Select the script file";
            openFile.Filter = "Select Valid Document(*.sql)|*.sql";
            openFile.FilterIndex = 1;
            openFile.Multiselect = true;
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    if (openFile.CheckFileExists)
                    {
                        string[] filesName = openFile.FileNames;
                        GetScript(filesName);
                        this.lbFolderPath.Text = "Folder Path: " + Path.GetDirectoryName(filesName[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"C:\Users\Admin\Documents";
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        //Right Click event in Form
        #region "Right click"
        private void upgradeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Upgrade();
            }
            catch (Exception ex) { throw ex; }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frm_GetListDB();
            }
            catch (Exception ex) { throw ex; }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion


        #region "Function"
        // Handle Script
        private string MakeScript(string[] filesName)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string file in filesName)
            {
                string script = File.ReadAllText(file);
                builder.AppendLine(script);
            }
            return builder.ToString();
        }
        //Filter sql file
        private string[] FileFilter(string path)
        {
            var needFiles = from file in Directory.EnumerateFiles(path)
                            let extension = Path.GetExtension(file)
                            where extension.Equals(".sql")
                            select file;
            return needFiles as string[];
        }
        //Add folder have 3 levels at max and it mean add a version folder
        //Important: Each folder contain only folders or script files and not empty        
        private void AddFolder(string pathVersion)
        {
            //Level 1: Get all folder containing script in folder Version
            string[] pathFolders = Directory.GetDirectories(pathVersion);
            string[] filesScript = Directory.GetFiles(pathVersion);
            if (pathFolders.Length > 0)
            {
                //If it is folder contain 
                foreach (string path in pathFolders)
                {
                    string[] files = Directory.GetFiles(path);
                    if (files.Length > 0)
                    {
                        GetScript(files);
                    }
                    else
                    {
                        string[] childFolders = Directory.GetDirectories(path);
                        foreach (string folder in childFolders)
                        {
                            string[] filesFolder = Directory.GetFiles(folder);
                            if (filesFolder.Length > 0)
                            {
                                GetScript(filesFolder);
                            }
                        }
                    }
                }
            }
            else if (filesScript.Length > 0)
            {
                GetScript(filesScript);
            }
            else
            {
                MessageBox.Show("Folder is empty");
            }
        }
        private void GetScript(string[] files)
        {
            Script script = new Script();
            script.Query = MakeScript(files);
            string scriptName = Path.GetDirectoryName(files[0]);
            script.Folder = new DirectoryInfo(scriptName).Name;
            frm_listScript.Add(script);
        }
        //Get List DBInfo
        private List<InfoDB> GetDBs(InfoLogin infoLogin)
        {
            List<InfoDB> list = new List<InfoDB>();
            var monitoring_db = ConfigurationManager.AppSettings.Get("default_monitoring_dbname");
            string connectString = attConnect[0] + infoLogin.Machine +
                                    attConnect[2] + infoLogin.User +
                                    attConnect[3] + infoLogin.Password;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                string query = String.Format(
                    @"SELECT s.datasource, ds.[catalog] , d.createdDate, d.brandname, d.domainname, s.user, s.password 
                    FROM (
                            ([{0}].[dbo].[storage] as s 
                            inner join 
                            [{0}].[dbo].[domain_storage] as ds 
                            on ds.storageid IN 
                                (SELECT ID FROM [{0}].[dbo].[storage] 
                                WHERE [user] = '{1}') AND s.[user] = '{1}')
                            inner join
                            [{0}].[dbo].[domain] as d 
                            on d.id = ds.domainid)", monitoring_db, infoLogin.User);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@user", infoLogin.User);
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
            try
            {
                this.gvDBList.DataSource = GetDBs(infoLogin);
            }
            catch (Exception bl) { throw bl; }
        }
        //Upgrade
        private void UpgradeDB(InfoLogin infoLogin)
        {
            string connectString = attConnect[0] + infoLogin.Machine +
                                    attConnect[1] + infoLogin.SeverName +
                                    attConnect[2] + infoLogin.User +
                                    attConnect[3] + infoLogin.Password;            
            
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string infoDB = infoLogin.Machine + ", " + infoLogin.SeverName;
                //Back up
                string resultBackUp = BackUp(connection, infoLogin.SeverName);                
                //Back up if success backup
                if (resultBackUp == null)
                {
                    ServerConnection svrConnection = new ServerConnection(connection);
                    Server server = new Server(svrConnection);
                    ////To Avoid TimeOut Exception
                    server.ConnectionContext.StatementTimeout = 60 * 60;
                    server.ConnectionContext.BeginTransaction();
                    foreach (Script item in frm_listScript)
                    {
                        Script stateScript;                        
                        try
                        {
                            server.ConnectionContext.ExecuteNonQuery(item.Query);
                        }
                        catch (ExecutionFailureException ex)
                        {                            
                            stateScript = item;
                            stateScript.DB = infoDB;
                            stateScript.ResultUpgrade = ex.GetBaseException().Message;                            
                            frm_resultList.Add(new Result(resultBackUp, stateScript));
                            server.ConnectionContext.RollBackTransaction();
                        }
                    }
                    server.ConnectionContext.CommitTransaction();
                    frm_resultList.Add(new Result(resultBackUp, infoDB));
                }
                else
                {
                    frm_resultList.Add(new Result(resultBackUp));
                }
            }
        }
        private bool frm_Upgrade()
        {
            List<InfoDB> listUpgrade = gvDBList.DataSource as List<InfoDB>;
            var upgradeList = listUpgrade.Where(sDB => sDB.UpdateChoice == true);
            frm_resultList = new List<Result>();
            frmUpgrade = new frmUpgradeState(frm_resultList, (List<InfoDB>)upgradeList);
            frmUpgrade.Show();
            if (frm_listScript.Count > 0)
            {
                foreach (InfoDB item in upgradeList)
                {
                    InfoLogin info = new InfoLogin(item.DataSource, item.Catalog, item.User, item.Password);
                    UpgradeDB(infoLogin);
                }
                return true;
            }
            MessageBox.Show("Do not have Script");
            return false;
        }
        private string BackUp(SqlConnection connection, string dbName)
        {
            string query = "BACKUP DATABASE databasename TO DISK = @path";
            string defaultPathBak = ConfigurationManager.AppSettings.Get("default_backup_directory");
            string filePath = String.Format(@"{0}\{1}_bak_{2}.bak}", 
                                            defaultPathBak, dbName, DateTime.Now.ToString("ddmmyyyy_hhmm"));
            
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@path", filePath);
                command.CommandTimeout = 60 * 60;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    return ex.Message;
                }
            }
            return null;
        }

        #endregion

        #region "Maybe delete"
        private bool frm_ExcuteScript(string fileScript, string catalog)
        {
            string cmdExcute = "/c sqlcmd" +
                            " -S " + infoLogin.Machine +
                            " -d " + catalog +
                            " -U " + infoLogin.User +
                            " -P " + infoLogin.Password +
                            " -i " + fileScript;

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd", cmdExcute);
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardError = true;

            Process process = new Process();
            process.StartInfo = startInfo;
            string errors;

            try
            {
                process.Start();
                errors = process.StandardError.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw ex;
            }

            if (errors.Length > 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        
    }
}
