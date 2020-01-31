using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace NovaDataManagement
{
    public partial class frmDatabaseList : Form
    {
        private List<Script> scripts = new List<Script>();
        private List<StringBuilder> allScript;

        private string m_machine = "";
        private string m_ServerDB = "";

        public string Machine { get; set; }
        public string InstanceSV{ get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public frmDatabaseList()
        {
            allScript = new List<StringBuilder>();
            allScript.Add(new StringBuilder());
            InitializeComponent();
        }

        #region "Event"
        private void frmDatabaseList_Load(object sender, EventArgs e)
        {
            try
            {
                //string connectString =
                //                "Data Source=" + this.Machine +
                //                ";Persist Security Info=True;User ID=" + this.Login +
                //                ";Password=" + this.Password;

                //gvDBlist.DataSource = ConnectDB.GetDBs(connectString);             
            }
            catch (Exception bl)
            {
                throw bl;
            }
        }
        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "C://Desktop";
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
                        makeScript(filesName);                        
                    }
                }
            }
            catch (Exception bt)
            {
                throw bt;
            }
        }
        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            //List<InfoDB> listUpgrade = gvDBlist.DataSource as List<InfoDB>;
            //var upgradeList = listUpgrade.Where(sDB => sDB.UpdateChoice == true);
            //bool result = false;
            //foreach (InfoDB item in upgradeList)
            //{
            //    result = ConnectDB.UpgradeDB(scripts, item.Catalog);
            //}

            //if (result)
            //{
            //    MessageBox.Show("Upgrade succes");
            //}
            //else
            //{
            //    MessageBox.Show("Fail: " + ConnectDB.errorScript.Folder);
            //}
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // gvDBlist.DataSource = ConnectDB.GetDBs();
            }
            catch (Exception bl)
            {
                throw bl;
            }
        }
        private void btnClearListScript_Click(object sender, EventArgs e)
        {
            try
            {
                allScript = new List<StringBuilder>();
                allScript.Add(new StringBuilder());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnAddVersion_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"C:\Users\Admin\Documents\SQL Server Management Studio\Test";
            folderBrowser.ShowNewFolderButton = false;
            string[] pathFolders;
            try
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    
                    //Get all folder containing script in folder Version
                    pathFolders = Directory.GetDirectories(folderBrowser.SelectedPath);
                    if (pathFolders.Length > 0)
                    {
                        //Make the big script for Update by 
                        foreach (string path in pathFolders)
                        {
                            string[] files = Directory.GetFiles(path);
                            makeScript(files);
                        }
                    }
                }
            }
            catch (Exception ex) { throw ex; }            
        }
        #endregion
        #region "Function"
        private void makeScript(string[] filesName)
        {
            if (filesName.Length > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (string file in filesName)
                {
                    string scriptName = Path.GetFileNameWithoutExtension(file);
                    stringBuilder.AppendLine(File.ReadAllText(file));
                }
                string tempScript = stringBuilder.ToString().ToLower();

                Regex regexCmd = new Regex("go");
                Regex regexFinal = new Regex("create|alter proc|procedure");

                List<string> tempListScript = new List<string>();
                tempListScript.AddRange(regexCmd.Split(tempScript));                
                foreach (string item in tempListScript)
                {
                    if (regexFinal.IsMatch(item))
                    {
                        allScript.Add(new StringBuilder(item));
                        if (tempListScript.IndexOf(item) != (tempListScript.Count() - 1))
                        {
                            allScript.Add(new StringBuilder());
                        }
                    }
                    else
                    {
                        allScript[allScript.Count - 1].AppendLine(item);
                    }
                }                
            }            
        }        
        #endregion
    }
}
