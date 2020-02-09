using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmActionState : Form
    {
        public List<Result> results;        
        public DataGridView StateList
        {
            get { return dgvStateList; }
        }
        public frmActionState(List<Result> listResult)
        {
            InitializeComponent();
            results = listResult;
            dgvStateList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStateList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStateList.DataSource = results;
            dgvStateList.Columns["Query"].Visible = false;
        }

        private void frmActionState_Load(object sender, EventArgs e)
        {

        }
    }
}
