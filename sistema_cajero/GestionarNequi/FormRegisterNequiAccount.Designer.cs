namespace GUI.Nequi
{
    partial class FormRegisterNequiAccount
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
            btnExit = new Button();
            btnRegisterNequiAccount = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtInitialBalance = new TextBox();
            txtPasswordAccount = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCardHolderName = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-2, -2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 33;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegisterNequiAccount
            // 
            btnRegisterNequiAccount.Anchor = AnchorStyles.Bottom;
            btnRegisterNequiAccount.Location = new Point(302, 376);
            btnRegisterNequiAccount.Name = "btnRegisterNequiAccount";
            btnRegisterNequiAccount.Size = new Size(75, 23);
            btnRegisterNequiAccount.TabIndex = 32;
            btnRegisterNequiAccount.Text = "Registrar";
            btnRegisterNequiAccount.UseVisualStyleBackColor = true;
            btnRegisterNequiAccount.Click += btnRegisterNequiAccount_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(276, 26);
            label5.Name = "label5";
            label5.Size = new Size(145, 15);
            label5.TabIndex = 31;
            label5.Text = "Registrar Cuenta de Nequi";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(89, 288);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 30;
            label4.Text = "Monto inicial:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(89, 244);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 29;
            label3.Text = "Contraseña de la cuenta:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(89, 202);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 28;
            label2.Text = "Número de teléfono:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(35, 147);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre del titular de la cuenta:";
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.Anchor = AnchorStyles.None;
            txtInitialBalance.BorderStyle = BorderStyle.FixedSingle;
            txtInitialBalance.Location = new Point(257, 280);
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(258, 23);
            txtInitialBalance.TabIndex = 26;
            // 
            // txtPasswordAccount
            // 
            txtPasswordAccount.Anchor = AnchorStyles.None;
            txtPasswordAccount.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordAccount.Location = new Point(257, 236);
            txtPasswordAccount.Name = "txtPasswordAccount";
            txtPasswordAccount.Size = new Size(258, 23);
            txtPasswordAccount.TabIndex = 25;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(257, 194);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(258, 23);
            txtPhoneNumber.TabIndex = 24;
            // 
            // txtCardHolderName
            // 
            txtCardHolderName.Anchor = AnchorStyles.None;
            txtCardHolderName.BorderStyle = BorderStyle.FixedSingle;
            txtCardHolderName.Location = new Point(257, 145);
            txtCardHolderName.Name = "txtCardHolderName";
            txtCardHolderName.Size = new Size(258, 23);
            txtCardHolderName.TabIndex = 23;
            // 
            // FormRegisterNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(btnExit);
            Controls.Add(btnRegisterNequiAccount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInitialBalance);
            Controls.Add(txtPasswordAccount);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCardHolderName);
            Name = "FormRegisterNequiAccount";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnRegisterNequiAccount;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtInitialBalance;
        private TextBox txtPasswordAccount;
        private TextBox txtPhoneNumber;
        private TextBox txtCardHolderName;
    }
}