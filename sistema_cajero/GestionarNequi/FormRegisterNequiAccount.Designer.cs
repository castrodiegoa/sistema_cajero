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
            label6 = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(219, 0, 130);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(231, 234, 239);
            btnExit.Location = new Point(-2, -2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 33;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegisterNequiAccount
            // 
            btnRegisterNequiAccount.Anchor = AnchorStyles.None;
            btnRegisterNequiAccount.BackColor = Color.FromArgb(219, 0, 130);
            btnRegisterNequiAccount.FlatStyle = FlatStyle.Popup;
            btnRegisterNequiAccount.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterNequiAccount.ForeColor = Color.FromArgb(231, 234, 239);
            btnRegisterNequiAccount.Location = new Point(266, 343);
            btnRegisterNequiAccount.Name = "btnRegisterNequiAccount";
            btnRegisterNequiAccount.Size = new Size(258, 23);
            btnRegisterNequiAccount.TabIndex = 32;
            btnRegisterNequiAccount.Text = "Registrar";
            btnRegisterNequiAccount.UseVisualStyleBackColor = false;
            btnRegisterNequiAccount.Click += btnRegisterNequiAccount_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(231, 234, 239);
            label5.Location = new Point(269, 24);
            label5.Name = "label5";
            label5.Size = new Size(164, 33);
            label5.TabIndex = 31;
            label5.Text = "Registrar Cuenta";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(231, 234, 239);
            label4.Location = new Point(50, 277);
            label4.Name = "label4";
            label4.Size = new Size(92, 22);
            label4.TabIndex = 30;
            label4.Text = "Monto inicial:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(231, 234, 239);
            label3.Location = new Point(50, 237);
            label3.Name = "label3";
            label3.Size = new Size(160, 22);
            label3.TabIndex = 29;
            label3.Text = "Contraseña de la cuenta:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 234, 239);
            label2.Location = new Point(50, 194);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 28;
            label2.Text = "Número de teléfono:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 234, 239);
            label1.Location = new Point(50, 146);
            label1.Name = "label1";
            label1.Size = new Size(201, 22);
            label1.TabIndex = 27;
            label1.Text = "Nombre del titular de la cuenta:";
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.Anchor = AnchorStyles.None;
            txtInitialBalance.BackColor = Color.FromArgb(77, 51, 78);
            txtInitialBalance.BorderStyle = BorderStyle.FixedSingle;
            txtInitialBalance.ForeColor = Color.FromArgb(231, 234, 239);
            txtInitialBalance.Location = new Point(266, 280);
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(258, 23);
            txtInitialBalance.TabIndex = 26;
            // 
            // txtPasswordAccount
            // 
            txtPasswordAccount.Anchor = AnchorStyles.None;
            txtPasswordAccount.BackColor = Color.FromArgb(77, 51, 78);
            txtPasswordAccount.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordAccount.ForeColor = Color.FromArgb(231, 234, 239);
            txtPasswordAccount.Location = new Point(266, 237);
            txtPasswordAccount.Name = "txtPasswordAccount";
            txtPasswordAccount.Size = new Size(258, 23);
            txtPasswordAccount.TabIndex = 25;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.BackColor = Color.FromArgb(77, 51, 78);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.ForeColor = Color.FromArgb(231, 234, 239);
            txtPhoneNumber.Location = new Point(266, 193);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(258, 23);
            txtPhoneNumber.TabIndex = 24;
            // 
            // txtCardHolderName
            // 
            txtCardHolderName.Anchor = AnchorStyles.None;
            txtCardHolderName.BackColor = Color.FromArgb(77, 51, 78);
            txtCardHolderName.BorderStyle = BorderStyle.FixedSingle;
            txtCardHolderName.ForeColor = Color.FromArgb(231, 234, 239);
            txtCardHolderName.Location = new Point(266, 145);
            txtCardHolderName.Name = "txtCardHolderName";
            txtCardHolderName.Size = new Size(258, 23);
            txtCardHolderName.TabIndex = 23;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(231, 234, 239);
            label6.Location = new Point(328, 65);
            label6.Name = "label6";
            label6.Size = new Size(47, 24);
            label6.TabIndex = 34;
            label6.Text = "Nequi";
            // 
            // FormRegisterNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 0, 26);
            ClientSize = new Size(684, 461);
            Controls.Add(label6);
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
        private Label label6;
    }
}