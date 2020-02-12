using System;
using System.Linq;
using System.Windows.Forms;


namespace NovaDataManagement
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = this.BackColor;
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

        public void Login()
        {
            frmLogin frmLog = new frmLogin();
            frmLog.Owner = this;               
            frmLog.ShowDialog();            
        }

        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                form.Dispose();
            }
        }
    }
}
