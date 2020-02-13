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
            this.dgvStateList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.Find_txt = new System.Windows.Forms.TextBox();
            this.cbFind = new System.Windows.Forms.ComboBox();
            this.lbSortby = new System.Windows.Forms.Label();
            this.lbFindBy = new System.Windows.Forms.Label();
            this.DataSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultUpgrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Folder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStateList
            // 
            this.dgvStateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStateList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSource,
            this.Catalog,
            this.Backup,
            this.ResultUpgrade,
            this.Folder,
            this.Note});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStateList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStateList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStateList.Location = new System.Drawing.Point(0, 40);
            this.dgvStateList.Name = "dgvStateList";
            this.dgvStateList.Size = new System.Drawing.Size(1184, 641);
            this.dgvStateList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.cbSort);
            this.panel1.Controls.Add(this.Find_txt);
            this.panel1.Controls.Add(this.cbFind);
            this.panel1.Controls.Add(this.lbSortby);
            this.panel1.Controls.Add(this.lbFindBy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 40);
            this.panel1.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(656, 9);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 5;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // cbSort
            // 
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Success",
            "Fail"});
            this.cbSort.Location = new System.Drawing.Point(536, 10);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(112, 21);
            this.cbSort.TabIndex = 4;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.cbSort_SelectedIndexChanged);
            // 
            // Find_txt
            // 
            this.Find_txt.Location = new System.Drawing.Point(208, 11);
            this.Find_txt.Name = "Find_txt";
            this.Find_txt.Size = new System.Drawing.Size(264, 20);
            this.Find_txt.TabIndex = 3;
            this.Find_txt.TextChanged += new System.EventHandler(this.Find_txt_TextChanged);
            // 
            // cbFind
            // 
            this.cbFind.FormattingEnabled = true;
            this.cbFind.Items.AddRange(new object[] {
            "Data Source",
            "Catalog"});
            this.cbFind.Location = new System.Drawing.Point(88, 10);
            this.cbFind.Name = "cbFind";
            this.cbFind.Size = new System.Drawing.Size(112, 21);
            this.cbFind.TabIndex = 2;
            // 
            // lbSortby
            // 
            this.lbSortby.AutoSize = true;
            this.lbSortby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSortby.Location = new System.Drawing.Point(477, 12);
            this.lbSortby.Name = "lbSortby";
            this.lbSortby.Size = new System.Drawing.Size(53, 16);
            this.lbSortby.TabIndex = 1;
            this.lbSortby.Text = "Sort by:";
            // 
            // lbFindBy
            // 
            this.lbFindBy.AutoSize = true;
            this.lbFindBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFindBy.Location = new System.Drawing.Point(16, 13);
            this.lbFindBy.Name = "lbFindBy";
            this.lbFindBy.Size = new System.Drawing.Size(55, 16);
            this.lbFindBy.TabIndex = 0;
            this.lbFindBy.Text = "Find by:";
            // 
            // DataSource
            // 
            this.DataSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
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
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "Note";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            this.Note.Width = 55;
            // 
            // frmActionState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvStateList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmActionState";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade State";
            this.Load += new System.EventHandler(this.frmActionState_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStateList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStateList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Find_txt;
        private System.Windows.Forms.ComboBox cbFind;
        private System.Windows.Forms.Label lbSortby;
        private System.Windows.Forms.Label lbFindBy;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Backup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultUpgrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Folder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}