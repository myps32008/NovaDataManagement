﻿using System;
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
        private StringBuilder totalScript;        
        private InfoLogin infoLogin;

        public frmDatabaseList(string machine, string instanceSV, string user, string password)
        {
            totalScript = new StringBuilder();
            infoLogin = new InfoLogin(machine, instanceSV, user, password);
            InitializeComponent();
        }

        #region "Event"
        private void frmDatabaseList_Load(object sender, EventArgs e)
        {
            try
            {
                this.gvDBList.DataSource = ConnectDB.GetDBs(infoLogin);             
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
            frm_Refresh();
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
                    AddVersion(folderBrowser.SelectedPath);
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
                    string[] filesName = Directory.GetFiles(folderBrowser.SelectedPath);
                    MakeScript(filesName);
                }
            }
            catch (Exception ex) { throw ex; }
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
                        MakeScript(filesName);
                    }
                }
            }
            catch (Exception bt)
            {
                throw bt;
            }
        }
        #endregion

        //Right Click event in Form
        #region "Right click"
        private void upgradeDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Upgrade();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion


        #region "Function"
        // Handle Script
        private void MakeScript(string[] filesName)
        {
            if (filesName.Length > 0)
            {
                foreach (string file in filesName)
                {
                    totalScript.AppendLine(File.ReadAllText(file));
                }
            }
        }
        private FolderBrowserDialog AddFolder()
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.SelectedPath = @"C:\Users\Admin\Documents\SQL Server Management Studio\Test";
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
                    MakeScript(files);
                }
            }            
        }
        //Get List DBInfo
        private void frm_Refresh()
        {
            try
            {
                this.gvDBList.DataSource = null;
                this.gvDBList.DataSource = ConnectDB.GetDBs(infoLogin);
            }
            catch (Exception bl) { throw bl; }
        }
        //Upgrade
        private bool frm_Upgrade()
        {
            List<InfoDB> listUpgrade = gvDBList.DataSource as List<InfoDB>;
            var upgradeList = listUpgrade.Where(sDB => sDB.UpdateChoice == true);
            bool result = false;
            foreach (InfoDB item in upgradeList)
            {
                frm_ExcuteScript(totalScript.ToString(), item.Catalog);
            }
            return result;
        }
        private bool frm_ExcuteScript(string script, string catalogDB)
        {
            
            return true;
        }

        #endregion

        
    }
}