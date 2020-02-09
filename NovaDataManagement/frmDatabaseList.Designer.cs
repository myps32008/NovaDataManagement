namespace NovaDataManagement
{
    partial class frmDatabaseList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseList));
            this.lbTotalWork = new System.Windows.Forms.Label();
            this.toolbarDatabaseList = new System.Windows.Forms.ToolStrip();
            this.btnUpgrade = new System.Windows.Forms.ToolStripButton();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnAddScript = new System.Windows.Forms.Button();
            this.btnClearScript = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Find_txt = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lbFolderBackup = new System.Windows.Forms.Label();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnShowScript = new System.Windows.Forms.Button();
            this.lbFolderPath = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lbFail = new System.Windows.Forms.Label();
            this.progressWork = new System.Windows.Forms.ProgressBar();
            this.lbStatAction = new System.Windows.Forms.Label();
            this.lbSuccess = new System.Windows.Forms.Label();
            this.mnsToolBarUpgrade = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.upgradeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDBList = new System.Windows.Forms.DataGridView();
            this.UpdateChoice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DomainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbarDatabaseList.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.mnsToolBarUpgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDBList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTotalWork
            // 
            this.lbTotalWork.AutoSize = true;
            this.lbTotalWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalWork.Location = new System.Drawing.Point(366, 10);
            this.lbTotalWork.Name = "lbTotalWork";
            this.lbTotalWork.Size = new System.Drawing.Size(97, 20);
            this.lbTotalWork.TabIndex = 4;
            this.lbTotalWork.Text = "Working: 0/0";
            // 
            // toolbarDatabaseList
            // 
            this.toolbarDatabaseList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpgrade,
            this.toolRefresh,
            this.btnHelp});
            this.toolbarDatabaseList.Location = new System.Drawing.Point(0, 0);
            this.toolbarDatabaseList.Name = "toolbarDatabaseList";
            this.toolbarDatabaseList.Size = new System.Drawing.Size(1240, 25);
            this.toolbarDatabaseList.TabIndex = 5;
            this.toolbarDatabaseList.Text = "toolStrip1";
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpgrade.Image = ((System.Drawing.Image)(resources.GetObject("btnUpgrade.Image")));
            this.btnUpgrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(90, 22);
            this.btnUpgrade.Text = "Upgrade DB";
            this.btnUpgrade.Click += new System.EventHandler(this.btnUpgrade_Click);
            // 
            // toolRefresh
            // 
            this.toolRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolRefresh.Image")));
            this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRefresh.Name = "toolRefresh";
            this.toolRefresh.Size = new System.Drawing.Size(66, 22);
            this.toolRefresh.Text = "Refresh";
            this.toolRefresh.Click += new System.EventHandler(this.toolRefresh_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(52, 22);
            this.btnHelp.Text = "Help";
            // 
            // btnAddScript
            // 
            this.btnAddScript.Location = new System.Drawing.Point(114, 8);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(100, 23);
            this.btnAddScript.TabIndex = 7;
            this.btnAddScript.Text = "Add script";
            this.btnAddScript.UseVisualStyleBackColor = true;
            this.btnAddScript.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnClearScript
            // 
            this.btnClearScript.Location = new System.Drawing.Point(220, 8);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(100, 23);
            this.btnClearScript.TabIndex = 10;
            this.btnClearScript.Text = "Clear script";
            this.btnClearScript.UseVisualStyleBackColor = true;
            this.btnClearScript.Click += new System.EventHandler(this.btnClearListScript_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(8, 8);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(100, 23);
            this.btnAddFolder.TabIndex = 11;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.cmbFind);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.Find_txt);
            this.pnlHeader.Controls.Add(this.btnResult);
            this.pnlHeader.Controls.Add(this.lbFolderBackup);
            this.pnlHeader.Controls.Add(this.btnBackUp);
            this.pnlHeader.Controls.Add(this.btnShowScript);
            this.pnlHeader.Controls.Add(this.lbFolderPath);
            this.pnlHeader.Controls.Add(this.btnClearScript);
            this.pnlHeader.Controls.Add(this.btnAddFolder);
            this.pnlHeader.Controls.Add(this.btnAddScript);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1240, 87);
            this.pnlHeader.TabIndex = 12;
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Items.AddRange(new object[] {
            "Data Source",
            "Catalog",
            "Created Date",
            "Domain Name",
            "Brand Name"});
            this.cmbFind.Location = new System.Drawing.Point(220, 46);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(100, 21);
            this.cmbFind.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Find by:";
            // 
            // Find_txt
            // 
            this.Find_txt.Location = new System.Drawing.Point(326, 47);
            this.Find_txt.Name = "Find_txt";
            this.Find_txt.Size = new System.Drawing.Size(206, 20);
            this.Find_txt.TabIndex = 18;
            this.Find_txt.TextChanged += new System.EventHandler(this.Find_txt_TextChanged);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(8, 45);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(100, 23);
            this.btnResult.TabIndex = 17;
            this.btnResult.Text = "Result Action";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lbFolderBackup
            // 
            this.lbFolderBackup.AutoSize = true;
            this.lbFolderBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolderBackup.Location = new System.Drawing.Point(562, 48);
            this.lbFolderBackup.Name = "lbFolderBackup";
            this.lbFolderBackup.Size = new System.Drawing.Size(99, 16);
            this.lbFolderBackup.TabIndex = 16;
            this.lbFolderBackup.Text = "Folder Backup:";
            this.lbFolderBackup.UseMnemonic = false;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(432, 8);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(100, 23);
            this.btnBackUp.TabIndex = 15;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnShowScript
            // 
            this.btnShowScript.Location = new System.Drawing.Point(326, 8);
            this.btnShowScript.Name = "btnShowScript";
            this.btnShowScript.Size = new System.Drawing.Size(100, 23);
            this.btnShowScript.TabIndex = 14;
            this.btnShowScript.Text = "Show script";
            this.btnShowScript.UseVisualStyleBackColor = true;
            // 
            // lbFolderPath
            // 
            this.lbFolderPath.AutoSize = true;
            this.lbFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFolderPath.Location = new System.Drawing.Point(562, 11);
            this.lbFolderPath.Name = "lbFolderPath";
            this.lbFolderPath.Size = new System.Drawing.Size(80, 16);
            this.lbFolderPath.TabIndex = 13;
            this.lbFolderPath.Text = "Folder Path:";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lbFail);
            this.pnlFooter.Controls.Add(this.progressWork);
            this.pnlFooter.Controls.Add(this.lbStatAction);
            this.pnlFooter.Controls.Add(this.lbSuccess);
            this.pnlFooter.Controls.Add(this.lbTotalWork);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 539);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1240, 40);
            this.pnlFooter.TabIndex = 13;
            // 
            // lbFail
            // 
            this.lbFail.AutoSize = true;
            this.lbFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFail.Location = new System.Drawing.Point(633, 11);
            this.lbFail.Name = "lbFail";
            this.lbFail.Size = new System.Drawing.Size(56, 20);
            this.lbFail.TabIndex = 8;
            this.lbFail.Text = "Failed:";
            // 
            // progressWork
            // 
            this.progressWork.Location = new System.Drawing.Point(131, 9);
            this.progressWork.Name = "progressWork";
            this.progressWork.Size = new System.Drawing.Size(211, 23);
            this.progressWork.TabIndex = 7;
            // 
            // lbStatAction
            // 
            this.lbStatAction.AutoSize = true;
            this.lbStatAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatAction.Location = new System.Drawing.Point(12, 11);
            this.lbStatAction.Name = "lbStatAction";
            this.lbStatAction.Size = new System.Drawing.Size(97, 20);
            this.lbStatAction.TabIndex = 6;
            this.lbStatAction.Text = "State Action";
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSuccess.Location = new System.Drawing.Point(518, 11);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(74, 20);
            this.lbSuccess.TabIndex = 5;
            this.lbSuccess.Text = "Success:";
            // 
            // mnsToolBarUpgrade
            // 
            this.mnsToolBarUpgrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upgradeDBToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.mnsToolBarUpgrade.Name = "mnsToolBarUpgrade";
            this.mnsToolBarUpgrade.Size = new System.Drawing.Size(138, 70);
            // 
            // upgradeDBToolStripMenuItem
            // 
            this.upgradeDBToolStripMenuItem.Name = "upgradeDBToolStripMenuItem";
            this.upgradeDBToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.upgradeDBToolStripMenuItem.Text = "Upgrade DB";
            this.upgradeDBToolStripMenuItem.Click += new System.EventHandler(this.upgradeDBToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // gvDBList
            // 
            this.gvDBList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDBList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateChoice,
            this.DataSource,
            this.Catalog,
            this.User,
            this.Password,
            this.CreatedDate,
            this.DomainName,
            this.BrandName});
            this.gvDBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDBList.Location = new System.Drawing.Point(0, 112);
            this.gvDBList.Name = "gvDBList";
            this.gvDBList.Size = new System.Drawing.Size(1240, 427);
            this.gvDBList.TabIndex = 14;
            // 
            // UpdateChoice
            // 
            this.UpdateChoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdateChoice.DataPropertyName = "UpdateChoice";
            this.UpdateChoice.HeaderText = "Update";
            this.UpdateChoice.Name = "UpdateChoice";
            this.UpdateChoice.Width = 48;
            // 
            // DataSource
            // 
            this.DataSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataSource.DataPropertyName = "DataSource";
            this.DataSource.HeaderText = "Data Source";
            this.DataSource.Name = "DataSource";
            this.DataSource.ReadOnly = true;
            // 
            // Catalog
            // 
            this.Catalog.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Catalog.DataPropertyName = "Catalog";
            this.Catalog.FillWeight = 200F;
            this.Catalog.HeaderText = "Catalog";
            this.Catalog.Name = "Catalog";
            this.Catalog.ReadOnly = true;
            // 
            // User
            // 
            this.User.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 54;
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 78;
            // 
            // CreatedDate
            // 
            this.CreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            this.CreatedDate.Width = 95;
            // 
            // DomainName
            // 
            this.DomainName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DomainName.DataPropertyName = "DomainName";
            this.DomainName.HeaderText = "Domain Name";
            this.DomainName.Name = "DomainName";
            this.DomainName.ReadOnly = true;
            this.DomainName.Width = 99;
            // 
            // BrandName
            // 
            this.BrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrandName.DataPropertyName = "BrandName";
            this.BrandName.HeaderText = "Brand Name";
            this.BrandName.Name = "BrandName";
            this.BrandName.ReadOnly = true;
            // 
            // frmDatabaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 579);
            this.ContextMenuStrip = this.mnsToolBarUpgrade;
            this.Controls.Add(this.gvDBList);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.toolbarDatabaseList);
            this.Name = "frmDatabaseList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade Databse";
            this.Load += new System.EventHandler(this.frmDatabaseList_Load);
            this.toolbarDatabaseList.ResumeLayout(false);
            this.toolbarDatabaseList.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.mnsToolBarUpgrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDBList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTotalWork;
        private System.Windows.Forms.ToolStrip toolbarDatabaseList;
        private System.Windows.Forms.ToolStripButton btnUpgrade;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Button btnAddScript;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.Button btnClearScript;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.ContextMenuStrip mnsToolBarUpgrade;
        private System.Windows.Forms.ToolStripMenuItem upgradeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView gvDBList;
        private System.Windows.Forms.Label lbFolderPath;
        private System.Windows.Forms.Button btnShowScript;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Label lbFolderBackup;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UpdateChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DomainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Find_txt;
        private System.Windows.Forms.Label lbSuccess;
        private System.Windows.Forms.Label lbStatAction;
        private System.Windows.Forms.ProgressBar progressWork;
        private System.Windows.Forms.Label lbFail;
        private System.Windows.Forms.ComboBox cmbFind;
    }
}