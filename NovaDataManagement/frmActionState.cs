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
        
        public frmActionState(List<Result> listResult)
        {
            
            InitializeComponent();
            this.dgvStateList.DataSource = listResult;
        }
    }
}
