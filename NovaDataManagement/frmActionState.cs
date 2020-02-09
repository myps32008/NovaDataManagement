using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmActionState : Form
    {
        public List<Result> results;
        public List<Result> ActionResults { get; set; }
        public DataGridView StateList
        {
            get { return dgvStateList; }
        }
        public frmActionState(List<Result> listResult)
        {
            InitializeComponent();
            ActionResults = listResult;
            dgvStateList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStateList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStateList.DataSource = listResult;
            dgvStateList.Columns["Query"].Visible = false;
        }

        private void frmActionState_Load(object sender, EventArgs e)
        {

        }
    }
}
