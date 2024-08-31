namespace sistema_cajero
{
    partial class FormRechargeDebitCard
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
            btnRechargeDebitCard = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAmountToRecharge = new TextBox();
            txtPasswordCard = new TextBox();
            txtNumberCard = new TextBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 33;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // btnRechargeDebitCard
            // 
            btnRechargeDebitCard.Anchor = AnchorStyles.Bottom;
            btnRechargeDebitCard.Location = new Point(299, 377);
            btnRechargeDebitCard.Name = "btnRechargeDebitCard";
            btnRechargeDebitCard.Size = new Size(75, 23);
            btnRechargeDebitCard.TabIndex = 32;
            btnRechargeDebitCard.Text = "Recargar";
            btnRechargeDebitCard.UseVisualStyleBackColor = true;
            btnRechargeDebitCard.Click += btnRechargeDebitCard_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(273, 27);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 31;
            label5.Text = "Recargar Tarjeta Débito";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(86, 289);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 30;
            label4.Text = "Monto a recargar:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(86, 245);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 29;
            label3.Text = "Contraseña de la tarjeta:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 28;
            label2.Text = "Número de tarjeta:";
            // 
            // txtAmountToRecharge
            // 
            txtAmountToRecharge.Anchor = AnchorStyles.None;
            txtAmountToRecharge.BorderStyle = BorderStyle.FixedSingle;
            txtAmountToRecharge.Location = new Point(254, 281);
            txtAmountToRecharge.Name = "txtAmountToRecharge";
            txtAmountToRecharge.Size = new Size(258, 23);
            txtAmountToRecharge.TabIndex = 26;
            // 
            // txtPasswordCard
            // 
            txtPasswordCard.Anchor = AnchorStyles.None;
            txtPasswordCard.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordCard.Location = new Point(254, 237);
            txtPasswordCard.Name = "txtPasswordCard";
            txtPasswordCard.Size = new Size(258, 23);
            txtPasswordCard.TabIndex = 25;
            // 
            // txtNumberCard
            // 
            txtNumberCard.Anchor = AnchorStyles.None;
            txtNumberCard.BorderStyle = BorderStyle.FixedSingle;
            txtNumberCard.Location = new Point(254, 195);
            txtNumberCard.Name = "txtNumberCard";
            txtNumberCard.Size = new Size(258, 23);
            txtNumberCard.TabIndex = 24;
            // 
            // FormRechargeCreditCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(btnExit);
            Controls.Add(btnRechargeDebitCard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAmountToRecharge);
            Controls.Add(txtPasswordCard);
            Controls.Add(txtNumberCard);
            Name = "FormRechargeCreditCard";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnRechargeDebitCard;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtAmountToRecharge;
        private TextBox txtPasswordCard;
        private TextBox txtNumberCard;
    }
}