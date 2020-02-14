using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            try
            {
                string[] testAcc = Properties.Settings.Default.test_login.Split(':');
                Machine_txt.Text = testAcc[0];
                Instance_txt.Text = testAcc[1];
                User_text.Text = testAcc[2];
                Password_txt.Text = testAcc[3];
            }
            catch (Exception ex) { throw ex; }            
        }

        #region "Event"
        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool validate = !(Machine_txt.Text.Equals("") && User_text.Text.Equals("") && Password_txt.Text.Equals(""));
            if (validate)
            {                
                InfoLogin info = 
                    new InfoLogin(
                        Machine_txt.Text.Trim(), 
                        Instance_txt.Text.Trim(), 
                        User_text.Text.Trim(), 
                        Password_txt.Text.Trim());                
                try
                {
                    Instance_txt.Text.Trim();
                    if (!Instance_txt.Text.Equals(""))
                    {
                        info.Machine += @"\" + Instance_txt.Text;
                    }
                    frmDatabaseList frm = new frmDatabaseList(info);
                    frm.MdiParent = Owner;
                    DialogResult = DialogResult.OK;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                catch (Exception eb)
                {
                    MessageBox.Show("Login failed: " + eb.Message);                    
                }
                if (cbxSave.Checked)
                {
                    string saveAcc = String.Format("{0}:{1}:{2}:{3}",
                        Machine_txt.Text.Trim(), Instance_txt.Text.Trim(), User_text.Text.Trim(), Password_txt.Text.Trim());
                    Properties.Settings.Default.test_login = saveAcc;
                    Properties.Settings.Default.Save();
                }                
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin đăng nhập.");
            }            
        }
        private void Machine_txt_Leave(object sender, EventArgs e)
        {

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            //    DataTable table = instance.GetDataSources();
            //    foreach (DataRow row in table.Rows)
            //    {
            //        InstanceSv.Items.Add(row["InstanceName"].ToString());
            //    }                
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }       
        #endregion

        #region "Function"

        #endregion
    }
}
