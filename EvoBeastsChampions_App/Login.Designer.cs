namespace EvoBeastsChampions_App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            label1 = new Label();
            label4 = new Label();
            txbUsername = new TextBox();
            PbEnter = new PictureBox();
            PbBlockPassword = new PictureBox();
            lblLinkCreateAccount = new LinkLabel();
            lblLinkCanNotLogin = new LinkLabel();
            panel3 = new Panel();
            label2 = new Label();
            txbPassword = new TextBox();
            panel2 = new Panel();
            lblTitle2 = new Label();
            panelLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)PbEnter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbBlockPassword).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Impact", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.DarkSlateGray;
            lblTitle.Location = new Point(319, 298);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 80);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "EvoBeast\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 85);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(71, 14);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(100, 23);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(12, 22);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(199, 23);
            txbUsername.TabIndex = 4;
            // 
            // PbEnter
            // 
            PbEnter.Location = new Point(113, 218);
            PbEnter.Name = "PbEnter";
            PbEnter.Size = new Size(59, 62);
            PbEnter.TabIndex = 17;
            PbEnter.TabStop = false;
            PbEnter.Click += PbEnter_Click;
            PbEnter.MouseEnter += PbEnter_MouseEnter;
            PbEnter.MouseLeave += PbEnter_MouseLeave;
            // 
            // PbBlockPassword
            // 
            PbBlockPassword.Image = Properties.Resources.hide;
            PbBlockPassword.Location = new Point(52, 201);
            PbBlockPassword.Name = "PbBlockPassword";
            PbBlockPassword.Size = new Size(24, 24);
            PbBlockPassword.TabIndex = 16;
            PbBlockPassword.TabStop = false;
            PbBlockPassword.Click += pbBlockPassword_Click;
            PbBlockPassword.MouseEnter += PbBlockPassword_MouseEnter;
            PbBlockPassword.MouseLeave += pbBlockPassword_MouseLeave;
            // 
            // lblLinkCreateAccount
            // 
            lblLinkCreateAccount.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            lblLinkCreateAccount.AutoSize = true;
            lblLinkCreateAccount.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLinkCreateAccount.LinkColor = Color.DimGray;
            lblLinkCreateAccount.Location = new Point(92, 366);
            lblLinkCreateAccount.Name = "lblLinkCreateAccount";
            lblLinkCreateAccount.Size = new Size(102, 16);
            lblLinkCreateAccount.TabIndex = 14;
            lblLinkCreateAccount.TabStop = true;
            lblLinkCreateAccount.Text = "CREAR CUENTA";
            lblLinkCreateAccount.LinkClicked += lblLinkCreateAccount_LinkClicked;
            // 
            // lblLinkCanNotLogin
            // 
            lblLinkCanNotLogin.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            lblLinkCanNotLogin.AutoSize = true;
            lblLinkCanNotLogin.BackColor = Color.Transparent;
            lblLinkCanNotLogin.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblLinkCanNotLogin.LinkColor = Color.DimGray;
            lblLinkCanNotLogin.Location = new Point(78, 340);
            lblLinkCanNotLogin.Name = "lblLinkCanNotLogin";
            lblLinkCanNotLogin.Size = new Size(136, 16);
            lblLinkCanNotLogin.TabIndex = 13;
            lblLinkCanNotLogin.TabStop = true;
            lblLinkCanNotLogin.Text = "¿NO PODES ENTRAR?";
            lblLinkCanNotLogin.LinkClicked += lblLinkCanNotLogin_LinkClicked;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txbPassword);
            panel3.Location = new Point(39, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(222, 54);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 85);
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(71, 14);
            label2.TabIndex = 0;
            label2.Text = "PASSWORD";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(12, 22);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(199, 23);
            txbPassword.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txbUsername);
            panel2.Location = new Point(39, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 54);
            panel2.TabIndex = 11;
            // 
            // lblTitle2
            // 
            lblTitle2.AutoSize = true;
            lblTitle2.BackColor = Color.Transparent;
            lblTitle2.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Italic, GraphicsUnit.Point);
            lblTitle2.ForeColor = Color.DarkGoldenrod;
            lblTitle2.Location = new Point(398, 366);
            lblTitle2.Name = "lblTitle2";
            lblTitle2.Size = new Size(171, 37);
            lblTitle2.TabIndex = 12;
            lblTitle2.Text = "Champions";
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(PbEnter);
            panelLogin.Controls.Add(panel3);
            panelLogin.Controls.Add(lblLinkCreateAccount);
            panelLogin.Controls.Add(panel2);
            panelLogin.Controls.Add(lblLinkCanNotLogin);
            panelLogin.Controls.Add(PbBlockPassword);
            panelLogin.Location = new Point(12, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(301, 398);
            panelLogin.TabIndex = 18;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 423);
            Controls.Add(lblTitle2);
            Controls.Add(lblTitle);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)PbEnter).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbBlockPassword).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private Label label1;
        private Label label4;
        private TextBox txbUsername;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private TextBox txbPassword;
        private LinkLabel lblLinkCreateAccount;
        private LinkLabel lblLinkCanNotLogin;
        private Label lblTitle2;
        private PictureBox PbBlockPassword;
        private PictureBox PbEnter;
        private Panel panelLogin;
    }
}