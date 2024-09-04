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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStep2_2WithdrawMoneyNequiAccount));
            label1 = new Label();
            btnBack = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(307, 67);
            label1.Name = "label1";
            label1.Size = new Size(72, 24);
            label1.TabIndex = 51;
            label1.Text = "Tu código";
            label1.Click += label1_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(219, 0, 130);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(231, 234, 239);
            btnBack.Location = new Point(-1, -1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(34, 30);
            btnBack.TabIndex = 52;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(31, 0, 32);
            label2.Font = new Font("Bahnschrift Condensed", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 234, 239);
            label2.Location = new Point(313, 209);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 53;
            label2.Text = "label2";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(31, 0, 32);
            label4.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(231, 234, 239);
            label4.Location = new Point(282, 255);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 55;
            label4.Text = "Vence a las";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(31, 0, 32);
            label5.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(231, 234, 239);
            label5.Location = new Point(346, 255);
            label5.Name = "label5";
            label5.Size = new Size(38, 18);
            label5.TabIndex = 56;
            label5.Text = "label5";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(212, 387);
            label3.Name = "label3";
            label3.Size = new Size(260, 18);
            label3.TabIndex = 57;
            label3.Text = "Escribe este número en el cajero para sacar plata.";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(166, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 58;
            pictureBox1.TabStop = false;
            // 
            // FormStep2_2WithdrawMoneyNequiAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 239);
            ClientSize = new Size(685, 461);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormStep2_2WithdrawMoneyNequiAccount";
            Text = "FormStep2_2WithdrawMoneyNequiAccount";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBack;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private PictureBox pictureBox1;
    }
}