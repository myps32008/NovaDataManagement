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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStateList = new System.Windows.Forms.DataGridView();
            this.DataSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultUpgrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStateList);
            this.panel2.Location = new System.Drawing.Point(3, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1173, 610);
            this.panel2.TabIndex = 10;
            // 
            // dgvStateList
            // 
            this.dgvStateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSource,
            this.Catalog,
            this.Backup,
            this.ResultUpgrade,
            this.Folder});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStateList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStateList.Location = new System.Drawing.Point(0, 0);
            this.dgvStateList.Name = "dgvStateList";
            this.dgvStateList.Size = new System.Drawing.Size(1173, 610);
            this.dgvStateList.TabIndex = 0;
            // 
            // DataSource
            // 
            this.DataSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DataSource.DataPropertyName = "DB";
            this.DataSource.HeaderText = "Data Source";
            this.DataSource.Name = "DataSource";
            this.DataSource.ReadOnly = true;
            this.DataSource.Width = 92;
            // 
            // Catalog
            // 
            this.Catalog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Catalog.DataPropertyName = "Catalog";
            this.Catalog.HeaderText = "Catalog";
            this.Catalog.Name = "Catalog";
            this.Catalog.ReadOnly = true;
            this.Catalog.Width = 68;
            // 
            // Backup
            // 
            this.Backup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Backup.DataPropertyName = "BackupResult";
            this.Backup.HeaderText = "Backup";
            this.Backup.Name = "Backup";
            this.Backup.ReadOnly = true;
            this.Backup.Width = 69;
            // 
            // ResultUpgrade
            // 
            this.ResultUpgrade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ResultUpgrade.DataPropertyName = "ResultUpgrade";
            this.ResultUpgrade.HeaderText = "Result Upgrade";
            this.ResultUpgrade.Name = "ResultUpgrade";
            this.ResultUpgrade.ReadOnly = true;
            // 
            // Folder
            // 
            this.Folder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Folder.DataPropertyName = "Folder";
            this.Folder.HeaderText = "Script error";
            this.Folder.Name = "Folder";
            this.Folder.ReadOnly = true;
            this.Folder.Width = 83;
            // 
            // frmActionState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActionState";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade State";
            this.Load += new System.EventHandler(this.frmActionState_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStateList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Backup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultUpgrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
    }
}