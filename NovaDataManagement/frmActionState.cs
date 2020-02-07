using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmActionState : Form
    {
        List<Result> results;
        public frmActionState(List<Result> listResult)
        {            
            InitializeComponent();
            results = listResult;
        }

        private void frmActionState_Load(object sender, EventArgs e)
        {            
            this.dgvStateList.DataSource = results;
            this.dgvStateList.Columns["Query"].Visible = false;
            this.dgvStateList.Columns["Folder"].Visible = false;
        }
    }
}
