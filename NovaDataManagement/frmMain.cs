using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmMain : Form
    {
        public static frmDatabaseList frmDB;       
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "Login")
                {
                    isOpen = true;
                    form.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmLogin frmLog = new frmLogin();
                frmLog.ShowDialog();                
                frmDB.MdiParent = this;
            }            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
