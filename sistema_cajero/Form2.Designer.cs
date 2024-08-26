namespace sistema_cajero
{
    partial class Form2
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
            txtName = new TextBox();
            txtNumberCard = new TextBox();
            txtPasswordCard = new TextBox();
            txtInitialAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegisterDebitCard = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.None;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(258, 146);
            txtName.Name = "txtName";
            txtName.Size = new Size(258, 23);
            txtName.TabIndex = 12;
            // 
            // txtNumberCard
            // 
            txtNumberCard.Anchor = AnchorStyles.None;
            txtNumberCard.BorderStyle = BorderStyle.FixedSingle;
            txtNumberCard.Location = new Point(258, 195);
            txtNumberCard.Name = "txtNumberCard";
            txtNumberCard.Size = new Size(258, 23);
            txtNumberCard.TabIndex = 13;
            // 
            // txtPasswordCard
            // 
            txtPasswordCard.Anchor = AnchorStyles.None;
            txtPasswordCard.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordCard.Location = new Point(258, 237);
            txtPasswordCard.Name = "txtPasswordCard";
            txtPasswordCard.Size = new Size(258, 23);
            txtPasswordCard.TabIndex = 14;
            // 
            // txtInitialAmount
            // 
            txtInitialAmount.Anchor = AnchorStyles.None;
            txtInitialAmount.BorderStyle = BorderStyle.FixedSingle;
            txtInitialAmount.Location = new Point(258, 281);
            txtInitialAmount.Name = "txtInitialAmount";
            txtInitialAmount.Size = new Size(258, 23);
            txtInitialAmount.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(90, 148);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(90, 203);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 17;
            label2.Text = "Número de tarjeta:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(90, 245);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 18;
            label3.Text = "Contraseña de la tarjeta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(90, 289);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 19;
            label4.Text = "Monto inicial:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(277, 27);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 20;
            label5.Text = "Registrar Tarjeta Débito";
            // 
            // btnRegisterDebitCard
            // 
            btnRegisterDebitCard.Anchor = AnchorStyles.Bottom;
            btnRegisterDebitCard.Location = new Point(303, 377);
            btnRegisterDebitCard.Name = "btnRegisterDebitCard";
            btnRegisterDebitCard.Size = new Size(75, 23);
            btnRegisterDebitCard.TabIndex = 21;
            btnRegisterDebitCard.Text = "Registrar";
            btnRegisterDebitCard.UseVisualStyleBackColor = true;
            btnRegisterDebitCard.Click += btnRegisterDebitCard_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 22;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(btnExit);
            Controls.Add(btnRegisterDebitCard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInitialAmount);
            Controls.Add(txtPasswordCard);
            Controls.Add(txtNumberCard);
            Controls.Add(txtName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtNumberCard;
        private TextBox txtPasswordCard;
        private TextBox txtInitialAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegisterDebitCard;
        private Button btnExit;
    }
}