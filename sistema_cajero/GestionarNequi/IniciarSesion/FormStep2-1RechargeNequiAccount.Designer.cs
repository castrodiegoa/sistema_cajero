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
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(279, 52);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 50;
            label1.Text = "Recharge Nequi";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(178, 44);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(33, 30);
            btnBack.TabIndex = 51;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRechargeNequiAccount
            // 
            btnRechargeNequiAccount.Anchor = AnchorStyles.Bottom;
            btnRechargeNequiAccount.Location = new Point(309, 259);
            btnRechargeNequiAccount.Name = "btnRechargeNequiAccount";
            btnRechargeNequiAccount.Size = new Size(75, 23);
            btnRechargeNequiAccount.TabIndex = 54;
            btnRechargeNequiAccount.Text = "Recargar";
            btnRechargeNequiAccount.UseVisualStyleBackColor = true;
            btnRechargeNequiAccount.Click += btnRechargeNequiAccount_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(119, 187);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 53;
            label4.Text = "Monto a recargar:";
            // 
            // txtAmountToRecharge
            // 
            txtAmountToRecharge.Anchor = AnchorStyles.None;
            txtAmountToRecharge.BorderStyle = BorderStyle.FixedSingle;
            txtAmountToRecharge.Location = new Point(268, 185);
            txtAmountToRecharge.Name = "txtAmountToRecharge";
            txtAmountToRecharge.Size = new Size(151, 23);
            txtAmountToRecharge.TabIndex = 52;
            // 
            // FormStep3RechargeNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
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