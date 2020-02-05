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

namespace NovaDataManagement
{
    public partial class frmDatabaseList : Form
    {
        private StringBuilder totalScript;
        private InfoLogin infoLogin;
        private List<string> statusUpdateDB;
        private List<Script> listFolderScript;
        private static string[] attConnect = {  "Data Source=",
                                                ";Initial Catalog=" ,
                                                ";Persist Security Info=True;User ID=",
                                                ";Password="};

        public frmDatabaseList(string machine, string instanceSV, string user, string password)
        {
            totalScript = new StringBuilder();
            statusUpdateDB = new List<string>();
            listFolderScript = new List<Script>();
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
            try
            {
                totalScript = new StringBuilder();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnAddVersion_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = AddFolder();
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowser.SelectedPath;
                    AddVersion(path);
                    this.lbFolderPath.Text = "Folder Path: " + path;
                }
            }
            catch (Exception ex) { throw ex; }
        }
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = AddFolder();
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowser.SelectedPath;
                    string[] filesName = Directory.GetFiles(path);
                    MakeScript(filesName);
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
                        Script script = GetScript(filesName);
                        listFolderScript.Add(script);
                        this.lbFolderPath.Text = "Folder Path: " + Path.GetDirectoryName(filesName[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
            if (filesName.Length > 0)
            {
                foreach (string file in filesName)
                {
                    string script = File.ReadAllText(file);
                    builder.AppendLine(script);
                }
                return builder.ToString();
            }
            return "";
        }
        private FolderBrowserDialog AddFolder()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"C:\Users\Admin\Documents";
            folderBrowser.ShowNewFolderButton = false;
            return folderBrowser;
        }
        private void AddVersion(string pathVersion)
        {
            //Get all folder containing script in folder Version
            string[] pathFolders = Directory.GetDirectories(pathVersion);           

            if (pathFolders.Length > 0)
            {
                //Make the big script for Update 
                foreach (string path in pathFolders)
                {
                    string[] files = Directory.GetFiles(path);
                    Script script = new Script();
                    if (files.Length > 0)
                    {
                        script = GetScript(files);
                        listFolderScript.Add(script);
                    }
                    else
                    {
                        string[] childFolders = Directory.GetDirectories(path);
                        foreach (string folder in childFolders)
                        {
                            string[] filesFolder = Directory.GetFiles(folder);
                            script = GetScript(filesFolder);
                            listFolderScript.Add(script);
                        }
                    }
                }
            }
        }
        private Script GetScript(string[] files)
        {
            Script script = new Script();
            script.Query = MakeScript(files);
            script.Folder = Path.GetDirectoryName(files[0]);            
            listFolderScript.Add(script);
            return script;
        }
        //Get List DBInfo
        private List<InfoDB> GetDBs(InfoLogin infoLogin)
        {
            List<InfoDB> list = new List<InfoDB>();
            string connectString = attConnect[0] + infoLogin.Machine +
                                    attConnect[2] + infoLogin.User +
                                    attConnect[3] + infoLogin.Password;
            using (SqlConnection con = new SqlConnection(connectString))
            {
                con.Open();
                string query = "SELECT s.datasource, ds.[catalog] , d.createdDate, d.brandname, d.domainname FROM (" +
                            "([CRM_Domain_Monitoring].[dbo].[storage] as s " +
                            "inner join " +
                            "[CRM_Domain_Monitoring].[dbo].[domain_storage] as ds " +
                            "on ds.storageid IN " +
                                "(SELECT ID FROM [CRM_Domain_Monitoring].[dbo].[storage] " +
                                "WHERE [user] = @user) AND s.[user] = @user) " +
                            "inner join " +
                            "[CRM_Domain_Monitoring].[dbo].[domain] as d " +
                            "on d.id = ds.domainid)";
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
                this.gvDBList.Columns["User"].Visible = false;
                this.gvDBList.Columns["Password"].Visible = false;
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
            using (SqlConnection con = new SqlConnection(connectString))
            {
                ServerConnection svrConnection = new ServerConnection(con);
                Server server = new Server(svrConnection);
                Script errorScript;
                server.ConnectionContext.BeginTransaction();
                foreach (Script item in listFolderScript)
                {
                    try
                    {
                        server.ConnectionContext.ExecuteNonQuery(item.Query);
                    }
                    catch (ExecutionFailureException ex)
                    {
                        errorScript = item;
                        errorScript.Error = ex.GetBaseException().Message;
                        server.ConnectionContext.RollBackTransaction();
                        MessageBox.Show(errorScript.DisplayError());
                    }
                }
                server.ConnectionContext.CommitTransaction();
            }
        }
        private bool frm_Upgrade()
        {
            List<InfoDB> listUpgrade = gvDBList.DataSource as List<InfoDB>;
            var upgradeList = listUpgrade.Where(sDB => sDB.UpdateChoice == true);

            if (listFolderScript.Count > 0)
            {
                foreach (InfoDB item in upgradeList)
                {
                    InfoLogin info = infoLogin;
                    info.SeverName = item.Catalog;
                    UpgradeDB(infoLogin);
                }
                return true;
            }
            MessageBox.Show("Do not have Script");
            return false;
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
