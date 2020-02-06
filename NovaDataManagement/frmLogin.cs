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
        }

        #region "Event"
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                bool IsValiate = true;
                /*
                 1. Kiểm tra các thông tin có thiêu, không chính xác: Nếu không đúng cảnh báo cho NSD
                 2. Nếu đúng thực hiện tiếp
                 */
                if (IsValiate)
                {
                    frmDatabaseList frm = new frmDatabaseList(this.Machine_txt.Text, 
                                                              "", //this.InstanceSv.SelectedItem.ToString()
                                                              this.User_text.Text,
                                                              this.Password_txt.Text);
                    frm.MdiParent = this.Owner;
                    this.DialogResult = DialogResult.OK;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.Show();
                }
                //this.Close();              
            }
            catch (Exception eb)
            {
                throw eb;
            }
        }
        private void Machine_txt_Leave(object sender, EventArgs e)
        {

        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
                //DataTable table = instance.GetDataSources();
                //foreach (DataRow row in table.Rows)
                //{
                //    InstanceSv.Items.Add(row["InstanceName"].ToString());
                //}
                Machine_txt.Text = "HUNGTRAN";
                InstanceSv.Items.Add("MSSQLSERVER");
                User_text.Text = "sa";
                Password_txt.Text = "svdhnt2010";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region "Function"
        private void CheckLogin()
        {
            bool check = Machine_txt.Text == null ;
        }
        #endregion
    }
}
