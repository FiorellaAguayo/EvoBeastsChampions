namespace EvoBeastsChampions_App
{
    partial class PasswordConfirmation
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
            txbPasswordOne = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbPasswordTwo = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txbPasswordOne
            // 
            txbPasswordOne.Location = new Point(29, 50);
            txbPasswordOne.Name = "txbPasswordOne";
            txbPasswordOne.Size = new Size(209, 23);
            txbPasswordOne.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 27);
            label1.Name = "label1";
            label1.Size = new Size(174, 17);
            label1.TabIndex = 1;
            label1.Text = "Ingrese la nueva contraseña:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 90);
            label2.Name = "label2";
            label2.Size = new Size(184, 17);
            label2.TabIndex = 3;
            label2.Text = "Confirme la nueva contraseña:";
            // 
            // txbPasswordTwo
            // 
            txbPasswordTwo.Location = new Point(29, 113);
            txbPasswordTwo.Name = "txbPasswordTwo";
            txbPasswordTwo.Size = new Size(209, 23);
            txbPasswordTwo.TabIndex = 2;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirm.Location = new Point(29, 152);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(99, 34);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "CONFIRMAR";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(134, 152);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "CANCELAR";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PasswordConfirmation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 207);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(label2);
            Controls.Add(txbPasswordTwo);
            Controls.Add(label1);
            Controls.Add(txbPasswordOne);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PasswordConfirmation";
            Text = "PasswordConfirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbPasswordOne;
        private Label label1;
        private Label label2;
        private TextBox txbPasswordTwo;
        private Button btnConfirm;
        private Button btnCancel;
    }
}