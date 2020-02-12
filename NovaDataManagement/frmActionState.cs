using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NovaDataManagement
{
    public partial class frmActionState : Form
    {
        private List<Result> frm_results;        
        public DataGridView StateList
        {
            get { return dgvStateList; }
        }
        public frmActionState(List<Result> listResult)
        {
            InitializeComponent();
            frm_results = listResult;
            dgvStateList.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStateList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStateList.DataSource = frm_results;
            dgvStateList.Columns["Query"].Visible = false;
        }

        private void frmActionState_Load(object sender, EventArgs e)
        {

        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbSort.SelectedIndex)
            {
                case 0: //Sort by Success
                    dgvStateList.DataSource = 
                        frm_results.FindAll(r => r.ResultUpgrade.Equals("Success")).
                            OrderBy(r => r.Catalog).ToList();
                    break;

                case 1: //Sort by Fail and by Error
                    dgvStateList.DataSource =
                        frm_results.FindAll(r => (!r.ResultUpgrade.Equals("Success"))).
                            OrderBy(r => r.Folder).
                            ThenBy(r => r.Catalog).ToList();
                    break;
                default:
                    dgvStateList.DataSource = frm_results;
                    break;
            }
            
        }
        private void Find_txt_TextChanged(object sender, EventArgs e)
        {
            if (Find_txt.Equals(""))
            {
                dgvStateList.DataSource = frm_results;
            }
            else
            {
                Regex regex = new Regex(Find_txt.Text);
                var temp = dgvStateList.DataSource as List<Result>;
                switch (cbFind.SelectedIndex)
                {
                    case 0:
                        dgvStateList.DataSource = temp.FindAll(r => regex.IsMatch(r.DB)).ToList();
                        break;
                    case 1:
                        dgvStateList.DataSource = temp.FindAll(r => regex.IsMatch(r.Catalog)).ToList();
                        break;
                    default:
                        dgvStateList.DataSource = frm_results;
                        break;
                }                
            }            
        }
        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dgvStateList.DataSource = frm_results;
        }
    }
}
