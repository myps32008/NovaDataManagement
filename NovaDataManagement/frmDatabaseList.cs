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


namespace NovaDataManagement
{
    public partial class frmDatabaseList : Form
    {
        private List<Script> scripts = new List<Script>();        
        public frmDatabaseList()
        {
            InitializeComponent();
        }

        private void frmDatabaseList_Load(object sender, EventArgs e)
        {            
            try
            {
                gvDBlist.DataSource = ConnectDB.GetDBs();
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
                        string directory = Path.GetDirectoryName(filesName[0]).Split(Path.DirectorySeparatorChar).Last();
                        
                        foreach (string file in filesName)
                        {
                            string scriptName = Path.GetFileNameWithoutExtension(file);
                            Script script = new Script(scriptName, directory, File.ReadAllText(file));
                            scripts.Add(script);
                        }                        
                    }
                }
            }
            catch (Exception bt)
            {
                throw bt;
            }
            this.dgvListScript.DataSource = null;
            this.dgvListScript.DataSource = scripts;            
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            List<InfoDB> listUpgrade = gvDBlist.DataSource as List<InfoDB>;
            var upgradeList = listUpgrade.Where(sDB => sDB.UpdateChoice == true);
            bool result = false;
            foreach (InfoDB item in upgradeList)
            {
                result = ConnectDB.UpgradeDB(scripts, item.Name);
            }

            if (result)
            {
                MessageBox.Show("Upgrade succes");
            }
            else
            {
                MessageBox.Show("Fail: " + ConnectDB.errorScript.Folder);
            }
        }

        private void toolRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                gvDBlist.DataSource = ConnectDB.GetDBs();
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
                this.dgvListScript.DataSource = null;
                scripts.Clear();
            }
            catch (Exception btnClearE)
            {

                throw btnClearE;
            }
        }
    }
}
