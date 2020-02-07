namespace NovaDataManagement
{
    partial class frmActionState
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbWorking = new System.Windows.Forms.Label();
            this.lbFinished = new System.Windows.Forms.Label();
            this.lbLeft = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.lbFailed = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStateList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(42, 63);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 16);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total: ";
            // 
            // lbWorking
            // 
            this.lbWorking.AutoSize = true;
            this.lbWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorking.Location = new System.Drawing.Point(147, 26);
            this.lbWorking.Name = "lbWorking";
            this.lbWorking.Size = new System.Drawing.Size(61, 16);
            this.lbWorking.TabIndex = 3;
            this.lbWorking.Text = "Working:";
            // 
            // lbFinished
            // 
            this.lbFinished.AutoSize = true;
            this.lbFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinished.Location = new System.Drawing.Point(25, 26);
            this.lbFinished.Name = "lbFinished";
            this.lbFinished.Size = new System.Drawing.Size(62, 16);
            this.lbFinished.TabIndex = 4;
            this.lbFinished.Text = "Finished:";
            // 
            // lbLeft
            // 
            this.lbLeft.AutoSize = true;
            this.lbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeft.Location = new System.Drawing.Point(287, 26);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(32, 16);
            this.lbLeft.TabIndex = 5;
            this.lbLeft.Text = "Left:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(443, 34);
            this.progressBar1.TabIndex = 6;
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccess.Location = new System.Drawing.Point(152, 63);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(56, 16);
            this.lbSuccess.TabIndex = 7;
            this.lbSuccess.Text = "Succes:";
            // 
            // lbFailed
            // 
            this.lbFailed.AutoSize = true;
            this.lbFailed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFailed.Location = new System.Drawing.Point(270, 63);
            this.lbFailed.Name = "lbFailed";
            this.lbFailed.Size = new System.Drawing.Size(49, 16);
            this.lbFailed.TabIndex = 8;
            this.lbFailed.Text = "Failed:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 162);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbFinished);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbFailed);
            this.groupBox1.Controls.Add(this.lbWorking);
            this.groupBox1.Controls.Add(this.lbSuccess);
            this.groupBox1.Controls.Add(this.lbLeft);
            this.groupBox1.Location = new System.Drawing.Point(46, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 98);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStateList);
            this.panel2.Location = new System.Drawing.Point(3, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(741, 272);
            this.panel2.TabIndex = 10;
            // 
            // dgvStateList
            // 
            this.dgvStateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStateList.Location = new System.Drawing.Point(0, 0);
            this.dgvStateList.Name = "dgvStateList";
            this.dgvStateList.Size = new System.Drawing.Size(741, 272);
            this.dgvStateList.TabIndex = 0;
            // 
            // frmActionState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActionState";
            this.ShowIcon = false;
            this.Text = "Upgrade State";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbWorking;
        private System.Windows.Forms.Label lbFinished;
        private System.Windows.Forms.Label lbLeft;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbFailed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStateList;
    }
}