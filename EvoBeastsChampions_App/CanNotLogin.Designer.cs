namespace EvoBeastsChampions_App
{
    partial class CanNotLogin
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
            panelLogin = new Panel();
            btnReady = new Button();
            llLogin = new LinkLabel();
            btnSendCode = new Button();
            panel1 = new Panel();
            label2 = new Label();
            txbCode = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            txbEmail = new TextBox();
            panelLogin.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnReady);
            panelLogin.Controls.Add(llLogin);
            panelLogin.Controls.Add(btnSendCode);
            panelLogin.Controls.Add(panel1);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label4);
            panelLogin.Controls.Add(panel2);
            panelLogin.Location = new Point(189, 12);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(378, 398);
            panelLogin.TabIndex = 19;
            // 
            // btnReady
            // 
            btnReady.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnReady.Location = new Point(128, 274);
            btnReady.Name = "btnReady";
            btnReady.Size = new Size(116, 35);
            btnReady.TabIndex = 22;
            btnReady.Text = "LISTO";
            btnReady.UseVisualStyleBackColor = true;
            btnReady.Click += btnReady_Click;
            // 
            // llLogin
            // 
            llLogin.ActiveLinkColor = Color.FromArgb(64, 64, 64);
            llLogin.AutoSize = true;
            llLogin.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            llLogin.LinkColor = Color.DimGray;
            llLogin.Location = new Point(143, 358);
            llLogin.Name = "llLogin";
            llLogin.Size = new Size(86, 16);
            llLogin.TabIndex = 21;
            llLogin.TabStop = true;
            llLogin.Text = "GO TO LOGIN";
            llLogin.LinkClicked += llLogin_LinkClicked;
            // 
            // btnSendCode
            // 
            btnSendCode.Location = new Point(285, 126);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new Size(76, 54);
            btnSendCode.TabIndex = 20;
            btnSendCode.Text = "ENVIAR CÓDIGO";
            btnSendCode.UseVisualStyleBackColor = true;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txbCode);
            panel1.Location = new Point(14, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 54);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(85, 85, 85);
            label2.Location = new Point(12, 5);
            label2.Name = "label2";
            label2.Size = new Size(51, 14);
            label2.TabIndex = 0;
            label2.Text = "CÓDIGO";
            // 
            // txbCode
            // 
            txbCode.Location = new Point(12, 22);
            txbCode.Name = "txbCode";
            txbCode.Size = new Size(316, 23);
            txbCode.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 69);
            label3.Name = "label3";
            label3.Size = new Size(358, 40);
            label3.TabIndex = 18;
            label3.Text = "Ingresá tu email. Recibirá el código de recuperación \r\nde la cuenta.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(64, 25);
            label4.Name = "label4";
            label4.Size = new Size(242, 28);
            label4.TabIndex = 7;
            label4.Text = "RECUPERAR CUENTA";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txbEmail);
            panel2.Location = new Point(14, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(265, 54);
            panel2.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(85, 85, 85);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(43, 14);
            label1.TabIndex = 0;
            label1.Text = "EMAIL";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(12, 22);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(237, 23);
            txbEmail.TabIndex = 4;
            // 
            // CanNotLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 423);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CanNotLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CanNotLogin";
            Load += CanNotLogin_Load;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private TextBox txbEmail;
        private Button btnSendCode;
        private Panel panel1;
        private Label label2;
        private TextBox txbCode;
        private Label label3;
        private LinkLabel llLogin;
        private Button btnReady;
    }
}