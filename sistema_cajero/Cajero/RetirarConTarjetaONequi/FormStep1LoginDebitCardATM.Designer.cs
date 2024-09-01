namespace sistema_cajero
{
    partial class FormStep1LoginDebitCardATM
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
            btnGetInto = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPasswordCard = new TextBox();
            txtNumberCard = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 40;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGetInto
            // 
            btnGetInto.Anchor = AnchorStyles.Bottom;
            btnGetInto.Location = new Point(299, 377);
            btnGetInto.Name = "btnGetInto";
            btnGetInto.Size = new Size(75, 23);
            btnGetInto.TabIndex = 39;
            btnGetInto.Text = "Ingresar";
            btnGetInto.UseVisualStyleBackColor = true;
            btnGetInto.Click += btnGetInto_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(273, 27);
            label5.Name = "label5";
            label5.Size = new Size(139, 15);
            label5.TabIndex = 38;
            label5.Text = "Retirar con Tarjeta Débito";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(86, 245);
            label3.Name = "label3";
            label3.Size = new Size(134, 15);
            label3.TabIndex = 37;
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
            label2.TabIndex = 36;
            label2.Text = "Número de tarjeta:";
            // 
            // txtPasswordCard
            // 
            txtPasswordCard.Anchor = AnchorStyles.None;
            txtPasswordCard.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordCard.Location = new Point(254, 237);
            txtPasswordCard.Name = "txtPasswordCard";
            txtPasswordCard.Size = new Size(258, 23);
            txtPasswordCard.TabIndex = 35;
            // 
            // txtNumberCard
            // 
            txtNumberCard.Anchor = AnchorStyles.None;
            txtNumberCard.BorderStyle = BorderStyle.FixedSingle;
            txtNumberCard.Location = new Point(254, 195);
            txtNumberCard.Name = "txtNumberCard";
            txtNumberCard.Size = new Size(258, 23);
            txtNumberCard.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(321, 51);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 41;
            label1.Text = "Paso 1";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnGetInto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPasswordCard);
            Controls.Add(txtNumberCard);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnGetInto;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtPasswordCard;
        private TextBox txtNumberCard;
        private Label label1;
    }
}