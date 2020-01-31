using System;
using System.Windows.Forms;


namespace NovaDataManagement
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        #region "Event"

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex) { throw ex; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Login();
            }
            catch (Exception ex) { throw ex; }
        }
        private void mstlogOut_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in this.MdiChildren)
                {
                    form.Close();
                }
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion

        #region "Sub/Function"

        private void Login()
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
                frmLog.Owner = this;               
                frmLog.ShowDialog();
            }
        }
        #endregion

       
    }
}
