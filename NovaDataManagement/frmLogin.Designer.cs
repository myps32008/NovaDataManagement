namespace NovaDataManagement
{
    partial class frmLogin
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
            this.lbServer = new System.Windows.Forms.Label();
            this.lbAcc = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.InstanceSv = new System.Windows.Forms.ComboBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.User_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Machine_txt = new System.Windows.Forms.TextBox();
            this.lbMachine = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbServer
            // 
            this.lbServer.BackColor = System.Drawing.Color.Transparent;
            this.lbServer.Location = new System.Drawing.Point(6, 46);
            this.lbServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(72, 20);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server Name";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAcc
            // 
            this.lbAcc.AutoSize = true;
            this.lbAcc.BackColor = System.Drawing.Color.Transparent;
            this.lbAcc.Location = new System.Drawing.Point(6, 78);
            this.lbAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAcc.Name = "lbAcc";
            this.lbAcc.Size = new System.Drawing.Size(47, 13);
            this.lbAcc.TabIndex = 1;
            this.lbAcc.Text = "Account";
            this.lbAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.BackColor = System.Drawing.Color.Transparent;
            this.lbPass.Location = new System.Drawing.Point(6, 110);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(53, 13);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password";
            this.lbPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 216);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 32);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.Location = new System.Drawing.Point(216, 216);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(66, 32);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // InstanceSv
            // 
            this.InstanceSv.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstanceSv.FormattingEnabled = true;
            this.InstanceSv.Location = new System.Drawing.Point(102, 46);
            this.InstanceSv.Margin = new System.Windows.Forms.Padding(2);
            this.InstanceSv.Name = "InstanceSv";
            this.InstanceSv.Size = new System.Drawing.Size(259, 25);
            this.InstanceSv.TabIndex = 5;
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(102, 110);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(259, 23);
            this.Password_txt.TabIndex = 7;
            // 
            // User_text
            // 
            this.User_text.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_text.Location = new System.Drawing.Point(102, 78);
            this.User_text.Margin = new System.Windows.Forms.Padding(2);
            this.User_text.Name = "User_text";
            this.User_text.Size = new System.Drawing.Size(259, 23);
            this.User_text.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Machine_txt);
            this.panel1.Controls.Add(this.lbMachine);
            this.panel1.Controls.Add(this.InstanceSv);
            this.panel1.Controls.Add(this.Password_txt);
            this.panel1.Controls.Add(this.lbServer);
            this.panel1.Controls.Add(this.User_text);
            this.panel1.Controls.Add(this.lbAcc);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Location = new System.Drawing.Point(8, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 143);
            this.panel1.TabIndex = 11;
            // 
            // Machine_txt
            // 
            this.Machine_txt.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Machine_txt.Location = new System.Drawing.Point(102, 13);
            this.Machine_txt.Margin = new System.Windows.Forms.Padding(2);
            this.Machine_txt.Name = "Machine_txt";
            this.Machine_txt.Size = new System.Drawing.Size(259, 23);
            this.Machine_txt.TabIndex = 9;
            this.Machine_txt.Leave += new System.EventHandler(this.Machine_txt_Leave);
            // 
            // lbMachine
            // 
            this.lbMachine.BackColor = System.Drawing.Color.Transparent;
            this.lbMachine.Location = new System.Drawing.Point(6, 13);
            this.lbMachine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMachine.Name = "lbMachine";
            this.lbMachine.Size = new System.Drawing.Size(72, 26);
            this.lbMachine.TabIndex = 8;
            this.lbMachine.Text = "Machine";
            this.lbMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Label lbAcc;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ComboBox InstanceSv;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox User_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Machine_txt;
        private System.Windows.Forms.Label lbMachine;
    }
}