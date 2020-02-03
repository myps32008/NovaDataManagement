﻿namespace NovaDataManagement
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
            this.CountDB = new System.Windows.Forms.Label();
            this.toolbarDatabaseList = new System.Windows.Forms.ToolStrip();
            this.btnUpgrade = new System.Windows.Forms.ToolStripButton();
            this.toolRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.btnAddScript = new System.Windows.Forms.Button();
            this.btnClearScript = new System.Windows.Forms.Button();
            this.btnAddVersion = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.mnsToolBarUpgrade = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.upgradeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvDBList = new System.Windows.Forms.DataGridView();
            this.toolbarDatabaseList.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.mnsToolBarUpgrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDBList)).BeginInit();
            this.SuspendLayout();
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
            // btnAddScript
            // 
            this.btnAddScript.Location = new System.Drawing.Point(216, 8);
            this.btnAddScript.Name = "btnAddScript";
            this.btnAddScript.Size = new System.Drawing.Size(100, 23);
            this.btnAddScript.TabIndex = 7;
            this.btnAddScript.Text = "Add script";
            this.btnAddScript.UseVisualStyleBackColor = true;
            this.btnAddScript.Click += new System.EventHandler(this.btnGetFile_Click);
            // 
            // btnClearScript
            // 
            this.btnClearScript.Location = new System.Drawing.Point(320, 8);
            this.btnClearScript.Name = "btnClearScript";
            this.btnClearScript.Size = new System.Drawing.Size(100, 23);
            this.btnClearScript.TabIndex = 10;
            this.btnClearScript.Text = "Clear script";
            this.btnClearScript.UseVisualStyleBackColor = true;
            this.btnClearScript.Click += new System.EventHandler(this.btnClearListScript_Click);
            // 
            // btnAddVersion
            // 
            this.btnAddVersion.Location = new System.Drawing.Point(8, 8);
            this.btnAddVersion.Name = "btnAddVersion";
            this.btnAddVersion.Size = new System.Drawing.Size(100, 23);
            this.btnAddVersion.TabIndex = 11;
            this.btnAddVersion.Text = "Add Version";
            this.btnAddVersion.UseVisualStyleBackColor = true;
            this.btnAddVersion.Click += new System.EventHandler(this.btnAddVersion_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnAddFolder);
            this.pnlHeader.Controls.Add(this.btnClearScript);
            this.pnlHeader.Controls.Add(this.btnAddVersion);
            this.pnlHeader.Controls.Add(this.btnAddScript);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 25);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1240, 39);
            this.pnlHeader.TabIndex = 12;
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(112, 8);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(100, 23);
            this.btnAddFolder.TabIndex = 12;
            this.btnAddFolder.Text = "Add Folder Script";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
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
            // mnsToolBarUpgrade
            // 
            this.mnsToolBarUpgrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upgradeDBToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnsToolBarUpgrade.Name = "mnsToolBarUpgrade";
            this.mnsToolBarUpgrade.Size = new System.Drawing.Size(138, 92);
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gvDBList
            // 
            this.gvDBList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDBList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDBList.Location = new System.Drawing.Point(0, 64);
            this.gvDBList.Name = "gvDBList";
            this.gvDBList.Size = new System.Drawing.Size(1240, 475);
            this.gvDBList.TabIndex = 14;
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
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.mnsToolBarUpgrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDBList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CountDB;
        private System.Windows.Forms.ToolStrip toolbarDatabaseList;
        private System.Windows.Forms.ToolStripButton btnUpgrade;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Button btnAddScript;
        private System.Windows.Forms.ToolStripButton toolRefresh;
        private System.Windows.Forms.Button btnClearScript;
        private System.Windows.Forms.Button btnAddVersion;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.ContextMenuStrip mnsToolBarUpgrade;
        private System.Windows.Forms.ToolStripMenuItem upgradeDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView gvDBList;
    }
}