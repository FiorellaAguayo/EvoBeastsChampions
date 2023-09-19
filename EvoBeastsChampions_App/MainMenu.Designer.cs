namespace EvoBeastsChampions_App
{
    partial class MainMenu
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
            panelMenu = new Panel();
            iconButtonMyAccount = new FontAwesome.Sharp.IconButton();
            iconButtonBank = new FontAwesome.Sharp.IconButton();
            iconButtonMyEvoBeasts = new FontAwesome.Sharp.IconButton();
            iconButtonStore = new FontAwesome.Sharp.IconButton();
            iconButtonMain = new FontAwesome.Sharp.IconButton();
            panelUp = new Panel();
            buttonDiamond = new Button();
            lblDiamond = new Label();
            pictureBox2 = new PictureBox();
            lblCoin = new Label();
            pictureBox1 = new PictureBox();
            panelChildForms = new Panel();
            lblAlias = new Label();
            pbProfile = new PictureBox();
            panelMenu.SuspendLayout();
            panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(iconButtonMyAccount);
            panelMenu.Controls.Add(iconButtonBank);
            panelMenu.Controls.Add(iconButtonMyEvoBeasts);
            panelMenu.Controls.Add(iconButtonStore);
            panelMenu.Controls.Add(iconButtonMain);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 42);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(146, 408);
            panelMenu.TabIndex = 0;
            // 
            // iconButtonMyAccount
            // 
            iconButtonMyAccount.Dock = DockStyle.Top;
            iconButtonMyAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonMyAccount.IconColor = Color.Black;
            iconButtonMyAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMyAccount.Location = new Point(0, 216);
            iconButtonMyAccount.Name = "iconButtonMyAccount";
            iconButtonMyAccount.Size = new Size(146, 54);
            iconButtonMyAccount.TabIndex = 7;
            iconButtonMyAccount.Text = "MI CUENTA";
            iconButtonMyAccount.UseVisualStyleBackColor = true;
            iconButtonMyAccount.Click += iconButtonMyAccount_Click;
            // 
            // iconButtonBank
            // 
            iconButtonBank.Dock = DockStyle.Top;
            iconButtonBank.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonBank.IconColor = Color.Black;
            iconButtonBank.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonBank.Location = new Point(0, 162);
            iconButtonBank.Name = "iconButtonBank";
            iconButtonBank.Size = new Size(146, 54);
            iconButtonBank.TabIndex = 6;
            iconButtonBank.Text = "BANCO";
            iconButtonBank.UseVisualStyleBackColor = true;
            iconButtonBank.Click += iconButtonBank_Click;
            // 
            // iconButtonMyEvoBeasts
            // 
            iconButtonMyEvoBeasts.Dock = DockStyle.Top;
            iconButtonMyEvoBeasts.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonMyEvoBeasts.IconColor = Color.Black;
            iconButtonMyEvoBeasts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMyEvoBeasts.Location = new Point(0, 108);
            iconButtonMyEvoBeasts.Name = "iconButtonMyEvoBeasts";
            iconButtonMyEvoBeasts.Size = new Size(146, 54);
            iconButtonMyEvoBeasts.TabIndex = 5;
            iconButtonMyEvoBeasts.Text = "MIS EVOBEASTS";
            iconButtonMyEvoBeasts.UseVisualStyleBackColor = true;
            iconButtonMyEvoBeasts.Click += iconButtonMyEvoBeasts_Click;
            // 
            // iconButtonStore
            // 
            iconButtonStore.Dock = DockStyle.Top;
            iconButtonStore.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonStore.IconColor = Color.Black;
            iconButtonStore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonStore.Location = new Point(0, 54);
            iconButtonStore.Name = "iconButtonStore";
            iconButtonStore.Size = new Size(146, 54);
            iconButtonStore.TabIndex = 4;
            iconButtonStore.Text = "TIENDA";
            iconButtonStore.UseVisualStyleBackColor = true;
            iconButtonStore.Click += iconButtonStore_Click;
            // 
            // iconButtonMain
            // 
            iconButtonMain.Dock = DockStyle.Top;
            iconButtonMain.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonMain.IconColor = Color.Black;
            iconButtonMain.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMain.Location = new Point(0, 0);
            iconButtonMain.Name = "iconButtonMain";
            iconButtonMain.Size = new Size(146, 54);
            iconButtonMain.TabIndex = 3;
            iconButtonMain.Text = "INICIO";
            iconButtonMain.UseVisualStyleBackColor = true;
            iconButtonMain.Click += iconButtonMain_Click;
            // 
            // panelUp
            // 
            panelUp.Controls.Add(pbProfile);
            panelUp.Controls.Add(lblAlias);
            panelUp.Controls.Add(buttonDiamond);
            panelUp.Controls.Add(lblDiamond);
            panelUp.Controls.Add(pictureBox2);
            panelUp.Controls.Add(lblCoin);
            panelUp.Controls.Add(pictureBox1);
            panelUp.Dock = DockStyle.Top;
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(800, 42);
            panelUp.TabIndex = 1;
            // 
            // buttonDiamond
            // 
            buttonDiamond.Image = Properties.Resources.plus;
            buttonDiamond.Location = new Point(452, 12);
            buttonDiamond.Name = "buttonDiamond";
            buttonDiamond.Size = new Size(26, 24);
            buttonDiamond.TabIndex = 4;
            buttonDiamond.UseVisualStyleBackColor = true;
            // 
            // lblDiamond
            // 
            lblDiamond.AutoSize = true;
            lblDiamond.BackColor = Color.Transparent;
            lblDiamond.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDiamond.Location = new Point(368, 16);
            lblDiamond.Name = "lblDiamond";
            lblDiamond.Size = new Size(78, 20);
            lblDiamond.TabIndex = 3;
            lblDiamond.Text = "diamantes";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.diamond;
            pictureBox2.Location = new Point(336, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblCoin
            // 
            lblCoin.AutoSize = true;
            lblCoin.BackColor = Color.Transparent;
            lblCoin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCoin.Location = new Point(177, 13);
            lblCoin.Name = "lblCoin";
            lblCoin.Size = new Size(70, 20);
            lblCoin.TabIndex = 1;
            lblCoin.Text = "monedas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dollar;
            pictureBox1.Location = new Point(145, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForms
            // 
            panelChildForms.Dock = DockStyle.Fill;
            panelChildForms.Location = new Point(146, 42);
            panelChildForms.Name = "panelChildForms";
            panelChildForms.Size = new Size(654, 408);
            panelChildForms.TabIndex = 2;
            // 
            // lblAlias
            // 
            lblAlias.AutoSize = true;
            lblAlias.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAlias.Location = new Point(707, 12);
            lblAlias.Name = "lblAlias";
            lblAlias.Size = new Size(41, 20);
            lblAlias.TabIndex = 0;
            lblAlias.Text = "Alias";
            // 
            // pbProfile
            // 
            pbProfile.Location = new Point(754, 6);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(34, 33);
            pbProfile.TabIndex = 0;
            pbProfile.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChildForms);
            Controls.Add(panelMenu);
            Controls.Add(panelUp);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainMenu";
            Text = "MainMenu";
            Load += MainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelUp.ResumeLayout(false);
            panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panel1;
        private Panel panelUp;
        private FontAwesome.Sharp.IconButton iconButtonMyAccount;
        private FontAwesome.Sharp.IconButton iconButtonBank;
        private FontAwesome.Sharp.IconButton iconButtonMyEvoBeasts;
        private FontAwesome.Sharp.IconButton iconButtonStore;
        private FontAwesome.Sharp.IconButton iconButtonMain;
        private Button buttonDiamond;
        private Label lblDiamond;
        private PictureBox pictureBox2;
        private Label lblCoin;
        private PictureBox pictureBox1;
        private Panel panelChildForms;
        private PictureBox pbProfile;
        private Label lblAlias;
    }
}