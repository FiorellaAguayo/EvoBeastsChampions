﻿namespace EvoBeastsChampions_App
{
    partial class Bank
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
            pictureBoxBackgroundPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxBackgroundPhoto
            // 
            pictureBoxBackgroundPhoto.Location = new Point(0, 0);
            pictureBoxBackgroundPhoto.Name = "pictureBoxBackgroundPhoto";
            pictureBoxBackgroundPhoto.Size = new Size(657, 410);
            pictureBoxBackgroundPhoto.TabIndex = 4;
            pictureBoxBackgroundPhoto.TabStop = false;
            // 
            // Bank
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 408);
            Controls.Add(pictureBoxBackgroundPhoto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Bank";
            Text = "Bank";
            Load += Bank_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxBackgroundPhoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxBackgroundPhoto;
    }
}