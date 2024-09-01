namespace GUI.GestionarNequi.IniciarSesion
{
    partial class FormStep2_2WithdrawMoneyNequiAccount
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(281, 96);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 51;
            label1.Text = "Withdraw Nequi Form";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(166, 81);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(33, 30);
            btnBack.TabIndex = 52;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(355, 162);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 53;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(238, 162);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 54;
            label3.Text = "Clave dinámica:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(276, 198);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 55;
            label4.Text = "Vence el:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gainsboro;
            label5.Location = new Point(355, 198);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 56;
            label5.Text = "label5";
            // 
            // FormStep2_2WithdrawMoneyNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "FormStep2_2WithdrawMoneyNequiAccount";
            Text = "FormStep2_2WithdrawMoneyNequiAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}