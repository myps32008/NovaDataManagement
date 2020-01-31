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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseList));
            this.gvDBlist = new System.Windows.Forms.DataGridView();
            this.CountDB = new System.Windows.Forms.Label();
            this.toolbarDatabaseList = new System.Windows.Forms.ToolStrip();
            this.btnUpgrade = new System.Windows.Forms.ToolStripButton();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnGetScript = new System.Windows.Forms.Button();
            this.btnClearListScript = new System.Windows.Forms.Button();
            this.btnAddVersion = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.UpdateVersion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datasource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDBlist)).BeginInit();
            this.toolbarDatabaseList.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvDBlist
            // 
            this.gvDBlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvDBlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDBlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateVersion,
            this.datasource,
            this.catalog,
            this.createdDate,
            this.domainName,
            this.brandName});
            this.gvDBlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDBlist.Location = new System.Drawing.Point(0, 64);
            this.gvDBlist.Name = "gvDBlist";
            this.gvDBlist.Size = new System.Drawing.Size(1240, 475);
            this.gvDBlist.TabIndex = 3;
            // 
            // CountDB
            // 
            this.CountDB.AutoSize = true;
            this.CountDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDB.Location = new System.Drawing.Point(8, 8);
            this.CountDB.Name = "CountDB";
            this.CountDB.Size = new System.Drawing.Size(60, 20);
            this.CountDB.TabIndex = 4;
            this.CountDB.Text = "Count: ";
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
            // btnGetScript
            // 
            this.btnGetScript.Location = new System.Drawing.Point(120, 8);
            this.btnGetScript.Name = "btnGetScript";
            this.btnGetScript.Size = new System.Drawing.Size(88, 23);
            this.btnGetScript.TabIndex = 7;
            this.btnGetScript.Text = "Add file script";
            this.btnGetScript.UseVisualStyleBackColor = true;
            this.btnGetScript.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnClearListScript
            // 
            this.btnClearListScript.Location = new System.Drawing.Point(224, 8);
            this.btnClearListScript.Name = "btnClearListScript";
            this.btnClearListScript.Size = new System.Drawing.Size(104, 23);
            this.btnClearListScript.TabIndex = 10;
            this.btnClearListScript.Text = "Clear script list";
            this.btnClearListScript.UseVisualStyleBackColor = true;
            this.btnClearListScript.Click += new System.EventHandler(this.btnClearListScript_Click);
            // 
            // btnAddVersion
            // 
            this.btnAddVersion.Location = new System.Drawing.Point(8, 8);
            this.btnAddVersion.Name = "btnAddVersion";
            this.btnAddVersion.Size = new System.Drawing.Size(96, 23);
            this.btnAddVersion.TabIndex = 11;
            this.btnAddVersion.Text = "Add Version";
            this.btnAddVersion.UseVisualStyleBackColor = true;
            this.btnAddVersion.Click += new System.EventHandler(this.btnAddVersion_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnClearListScript);
            this.pnlHeader.Controls.Add(this.btnAddVersion);
            this.pnlHeader.Controls.Add(this.btnGetScript);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1240, 39);
            this.pnlHeader.TabIndex = 12;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.CountDB);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 539);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1240, 40);
            this.pnlFooter.TabIndex = 13;
            // 
            // UpdateVersion
            // 
            this.UpdateVersion.DataPropertyName = "UpdateChoice";
            this.UpdateVersion.HeaderText = "Update Version";
            this.UpdateVersion.Name = "UpdateVersion";
            this.UpdateVersion.Width = 77;
            // 
            // datasource
            // 
            this.datasource.DataPropertyName = "DataSource";
            this.datasource.HeaderText = "Data Source";
            this.datasource.Name = "datasource";
            this.datasource.ReadOnly = true;
            this.datasource.Width = 85;
            // 
            // catalog
            // 
            this.catalog.DataPropertyName = "Catalog";
            this.catalog.FillWeight = 200F;
            this.catalog.HeaderText = "Catalog";
            this.catalog.Name = "catalog";
            this.catalog.ReadOnly = true;
            this.catalog.Width = 68;
            // 
            // createdDate
            // 
            this.createdDate.DataPropertyName = "CreatedDate";
            this.createdDate.FillWeight = 150F;
            this.createdDate.HeaderText = "Created Date";
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Width = 87;
            // 
            // domainName
            // 
            this.domainName.DataPropertyName = "DomainName";
            this.domainName.HeaderText = "Domain Name";
            this.domainName.Name = "domainName";
            this.domainName.ReadOnly = true;
            this.domainName.Width = 91;
            // 
            // brandName
            // 
            this.brandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.brandName.DataPropertyName = "BrandName";
            this.brandName.HeaderText = "Brand Name";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // frmDatabaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 579);
            this.Controls.Add(this.gvDBlist);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.toolbarDatabaseList);
            this.Name = "frmDatabaseList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade Databse";
            this.Load += new System.EventHandler(this.frmDatabaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDBlist)).EndInit();
            this.toolbarDatabaseList.ResumeLayout(false);
            this.toolbarDatabaseList.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvDBlist;
        private System.Windows.Forms.Label CountDB;
        private System.Windows.Forms.ToolStrip toolbarDatabaseList;
        private System.Windows.Forms.ToolStripButton btnUpgrade;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Button btnGetScript;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.Button btnClearListScript;
        private System.Windows.Forms.Button btnAddVersion;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UpdateVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasource;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
    }
}