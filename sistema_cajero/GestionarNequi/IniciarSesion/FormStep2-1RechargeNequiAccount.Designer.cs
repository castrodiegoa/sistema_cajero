namespace GUI.GestionarNequi.IniciarSesion
{
    partial class FormStep3RechargeNequiAccount
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
            label1 = new Label();
            btnBack = new Button();
            btnRechargeNequiAccount = new Button();
            label4 = new Label();
            txtAmountToRecharge = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 234, 239);
            label1.Location = new Point(251, 44);
            label1.Name = "label1";
            label1.Size = new Size(203, 33);
            label1.TabIndex = 50;
            label1.Text = "Recargar Nequi";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(219, 0, 130);
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(231, 234, 239);
            btnBack.Location = new Point(-1, -1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(33, 30);
            btnBack.TabIndex = 51;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnRechargeNequiAccount
            // 
            btnRechargeNequiAccount.Anchor = AnchorStyles.Bottom;
            btnRechargeNequiAccount.BackColor = Color.FromArgb(219, 0, 130);
            btnRechargeNequiAccount.FlatStyle = FlatStyle.Popup;
            btnRechargeNequiAccount.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRechargeNequiAccount.ForeColor = Color.FromArgb(231, 234, 239);
            btnRechargeNequiAccount.Location = new Point(233, 262);
            btnRechargeNequiAccount.Name = "btnRechargeNequiAccount";
            btnRechargeNequiAccount.Size = new Size(258, 23);
            btnRechargeNequiAccount.TabIndex = 54;
            btnRechargeNequiAccount.Text = "Recargar";
            btnRechargeNequiAccount.UseVisualStyleBackColor = false;
            btnRechargeNequiAccount.Click += btnRechargeNequiAccount_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(231, 234, 239);
            label4.Location = new Point(110, 179);
            label4.Name = "label4";
            label4.Size = new Size(117, 22);
            label4.TabIndex = 53;
            label4.Text = "Monto a recargar:";
            label4.Click += label4_Click;
            // 
            // txtAmountToRecharge
            // 
            txtAmountToRecharge.Anchor = AnchorStyles.None;
            txtAmountToRecharge.BackColor = Color.FromArgb(77, 51, 78);
            txtAmountToRecharge.BorderStyle = BorderStyle.FixedSingle;
            txtAmountToRecharge.ForeColor = Color.FromArgb(231, 234, 239);
            txtAmountToRecharge.Location = new Point(233, 179);
            txtAmountToRecharge.Name = "txtAmountToRecharge";
            txtAmountToRecharge.Size = new Size(258, 23);
            txtAmountToRecharge.TabIndex = 52;
            // 
            // FormStep3RechargeNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 0, 26);
            ClientSize = new Size(684, 461);
            Controls.Add(btnRechargeNequiAccount);
            Controls.Add(label4);
            Controls.Add(txtAmountToRecharge);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "FormStep3RechargeNequiAccount";
            Text = "FormStep3RechargeNequiAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Button btnRechargeNequiAccount;
        private Label label4;
        private TextBox txtAmountToRecharge;
    }
}