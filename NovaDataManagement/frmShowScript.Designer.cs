namespace NovaDataManagement
{
    partial class frmShowScript
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
            this.dgvListScript = new System.Windows.Forms.DataGridView();
            this.panelListScript = new System.Windows.Forms.Panel();
            this.panelScript = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbListScript = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListScript)).BeginInit();
            this.panelListScript.SuspendLayout();
            this.panelScript.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListScript
            // 
            this.dgvListScript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListScript.Location = new System.Drawing.Point(0, 0);
            this.dgvListScript.Name = "dgvListScript";
            this.dgvListScript.Size = new System.Drawing.Size(350, 400);
            this.dgvListScript.TabIndex = 0;
            // 
            // panelListScript
            // 
            this.panelListScript.Controls.Add(this.dgvListScript);
            this.panelListScript.Location = new System.Drawing.Point(12, 49);
            this.panelListScript.Name = "panelListScript";
            this.panelListScript.Size = new System.Drawing.Size(350, 400);
            this.panelListScript.TabIndex = 1;
            // 
            // panelScript
            // 
            this.panelScript.Controls.Add(this.richTextBox1);
            this.panelScript.Location = new System.Drawing.Point(422, 49);
            this.panelScript.Name = "panelScript";
            this.panelScript.Size = new System.Drawing.Size(350, 400);
            this.panelScript.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(350, 400);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbListScript
            // 
            this.lbListScript.AutoSize = true;
            this.lbListScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListScript.Location = new System.Drawing.Point(12, 17);
            this.lbListScript.Name = "lbListScript";
            this.lbListScript.Size = new System.Drawing.Size(102, 20);
            this.lbListScript.TabIndex = 3;
            this.lbListScript.Text = "List of scripts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Script";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(371, 128);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(45, 42);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(371, 176);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(45, 42);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // frmShowScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbListScript);
            this.Controls.Add(this.panelScript);
            this.Controls.Add(this.panelListScript);
            this.Name = "frmShowScript";
            this.Text = "frmShowScript";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListScript)).EndInit();
            this.panelListScript.ResumeLayout(false);
            this.panelScript.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListScript;
        private System.Windows.Forms.Panel panelListScript;
        private System.Windows.Forms.Panel panelScript;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbListScript;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDown;
    }
}