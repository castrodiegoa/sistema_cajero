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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRechargeDebitCard));
            btnExit = new Button();
            btnRechargeDebitCard = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAmountToRecharge = new TextBox();
            txtPasswordCard = new TextBox();
            txtNumberCard = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(1, 1, 1);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(246, 150, 76);
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 33;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click;
            // 
            // btnRechargeDebitCard
            // 
            btnRechargeDebitCard.Anchor = AnchorStyles.Bottom;
            btnRechargeDebitCard.BackColor = Color.FromArgb(1, 1, 1);
            btnRechargeDebitCard.FlatStyle = FlatStyle.Popup;
            btnRechargeDebitCard.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRechargeDebitCard.ForeColor = Color.FromArgb(254, 242, 0);
            btnRechargeDebitCard.Location = new Point(343, 353);
            btnRechargeDebitCard.Name = "btnRechargeDebitCard";
            btnRechargeDebitCard.Size = new Size(75, 23);
            btnRechargeDebitCard.TabIndex = 32;
            btnRechargeDebitCard.Text = "Recargar";
            btnRechargeDebitCard.UseVisualStyleBackColor = false;
            btnRechargeDebitCard.Click += btnRechargeDebitCard_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(1, 1, 1);
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(248, 248, 248);
            label5.Location = new Point(260, 85);
            label5.Name = "label5";
            label5.Size = new Size(224, 33);
            label5.TabIndex = 31;
            label5.Text = "Recargar Tarjeta Débito";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(1, 1, 1);
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(248, 248, 248);
            label4.Location = new Point(86, 289);
            label4.Name = "label4";
            label4.Size = new Size(106, 21);
            label4.TabIndex = 30;
            label4.Text = "Monto a recargar:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(1, 1, 1);
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(248, 248, 248);
            label3.Location = new Point(86, 245);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 29;
            label3.Text = "Contraseña de la tarjeta:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(1, 1, 1);
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(248, 248, 248);
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 28;
            label2.Text = "Número de tarjeta:";
            // 
            // txtAmountToRecharge
            // 
            txtAmountToRecharge.Anchor = AnchorStyles.None;
            txtAmountToRecharge.BackColor = Color.FromArgb(10, 10, 10);
            txtAmountToRecharge.BorderStyle = BorderStyle.FixedSingle;
            txtAmountToRecharge.Location = new Point(254, 286);
            txtAmountToRecharge.Name = "txtAmountToRecharge";
            txtAmountToRecharge.Size = new Size(258, 23);
            txtAmountToRecharge.TabIndex = 26;
            txtAmountToRecharge.TextChanged += txtAmountToRecharge_TextChanged;
            // 
            // txtPasswordCard
            // 
            txtPasswordCard.Anchor = AnchorStyles.None;
            txtPasswordCard.BackColor = Color.FromArgb(10, 10, 10);
            txtPasswordCard.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordCard.Location = new Point(254, 243);
            txtPasswordCard.Name = "txtPasswordCard";
            txtPasswordCard.Size = new Size(258, 23);
            txtPasswordCard.TabIndex = 25;
            // 
            // txtNumberCard
            // 
            txtNumberCard.Anchor = AnchorStyles.None;
            txtNumberCard.BackColor = Color.FromArgb(10, 10, 10);
            txtNumberCard.BorderStyle = BorderStyle.FixedSingle;
            txtNumberCard.Location = new Point(254, 200);
            txtNumberCard.Name = "txtNumberCard";
            txtNumberCard.Size = new Size(258, 23);
            txtNumberCard.TabIndex = 24;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 36;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 353);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(508, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // FormRechargeDebitCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 1, 1);
            ClientSize = new Size(684, 461);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(btnRechargeDebitCard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAmountToRecharge);
            Controls.Add(txtPasswordCard);
            Controls.Add(txtNumberCard);
            Name = "FormRechargeDebitCard";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}