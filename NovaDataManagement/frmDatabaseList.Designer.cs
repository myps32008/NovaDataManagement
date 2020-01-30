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
            this.toolData = new System.Windows.Forms.ToolStrip();
            this.btnUpgrade = new System.Windows.Forms.ToolStripButton();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnGetScript = new System.Windows.Forms.Button();
            this.btnClearListScript = new System.Windows.Forms.Button();
            this.UpdateVersion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datasource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDBlist)).BeginInit();
            this.toolData.SuspendLayout();
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
            this.brandName,
            this.domainName,
            this.createdDate});
            this.gvDBlist.Location = new System.Drawing.Point(8, 72);
            this.gvDBlist.Name = "gvDBlist";
            this.gvDBlist.Size = new System.Drawing.Size(1220, 472);
            this.gvDBlist.TabIndex = 3;
            // 
            // CountDB
            // 
            this.CountDB.AutoSize = true;
            this.CountDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountDB.Location = new System.Drawing.Point(8, 552);
            this.CountDB.Name = "CountDB";
            this.CountDB.Size = new System.Drawing.Size(60, 20);
            this.CountDB.TabIndex = 4;
            this.CountDB.Text = "Count: ";
            // 
            // toolData
            // 
            this.toolData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpgrade,
            this.toolRefresh,
            this.btnHelp});
            this.toolData.Location = new System.Drawing.Point(0, 0);
            this.toolData.Name = "toolData";
            this.toolData.Size = new System.Drawing.Size(1240, 25);
            this.toolData.TabIndex = 5;
            this.toolData.Text = "toolStrip1";
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
            this.btnGetScript.Location = new System.Drawing.Point(16, 40);
            this.btnGetScript.Name = "btnGetScript";
            this.btnGetScript.Size = new System.Drawing.Size(88, 23);
            this.btnGetScript.TabIndex = 7;
            this.btnGetScript.Text = "Add file script";
            this.btnGetScript.UseVisualStyleBackColor = true;
            this.btnGetScript.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnClearListScript
            // 
            this.btnClearListScript.Location = new System.Drawing.Point(112, 40);
            this.btnClearListScript.Name = "btnClearListScript";
            this.btnClearListScript.Size = new System.Drawing.Size(104, 23);
            this.btnClearListScript.TabIndex = 10;
            this.btnClearListScript.Text = "Clear script list";
            this.btnClearListScript.UseVisualStyleBackColor = true;
            this.btnClearListScript.Click += new System.EventHandler(this.btnClearListScript_Click);
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
            this.catalog.HeaderText = "Catalog";
            this.catalog.Name = "catalog";
            this.catalog.ReadOnly = true;
            this.catalog.Width = 68;
            // 
            // brandName
            // 
            this.brandName.DataPropertyName = "BrandName";
            this.brandName.HeaderText = "Brand Name";
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            this.brandName.Width = 84;
            // 
            // domainName
            // 
            this.domainName.DataPropertyName = "DomainName";
            this.domainName.HeaderText = "Domain Name";
            this.domainName.Name = "domainName";
            this.domainName.ReadOnly = true;
            this.domainName.Width = 91;
            // 
            // createdDate
            // 
            this.createdDate.DataPropertyName = "CreatedDate";
            this.createdDate.HeaderText = "Created Date";
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Width = 87;
            // 
            // frmDatabaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 579);
            this.Controls.Add(this.btnClearListScript);
            this.Controls.Add(this.btnGetScript);
            this.Controls.Add(this.toolData);
            this.Controls.Add(this.CountDB);
            this.Controls.Add(this.gvDBlist);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDatabaseList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upgrade Databse";
            this.Load += new System.EventHandler(this.frmDatabaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDBlist)).EndInit();
            this.toolData.ResumeLayout(false);
            this.toolData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvDBlist;
        private System.Windows.Forms.Label CountDB;
        private System.Windows.Forms.ToolStrip toolData;
        private System.Windows.Forms.ToolStripButton btnUpgrade;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Button btnGetScript;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.Button btnClearListScript;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UpdateVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn datasource;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDate;
    }
}