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
        public static InfoLogin login = null;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                login = new InfoLogin(this.Machine_txt.Text,
                                      this.InstanceSv.SelectedItem.ToString(),
                                      this.User_text.Text,
                                      this.Password_txt.Text);
               

                frmDatabaseList DBlist = new frmDatabaseList();
                DBlist.Show();
                
            }
            catch (Exception eb)
            {
                throw eb;
            }            
        }
        private void Machine_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                //SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
                //DataTable table = instance.GetDataSources();
                //foreach (DataRow row in table.Rows)
                //{
                //    InstanceSv.Items.Add(row["InstanceName"].ToString());
                //}
                InstanceSv.Items.Add("MSSql");

            }
            catch (Exception Einst)
            {
                throw Einst;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
