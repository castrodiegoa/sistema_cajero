namespace sistema_cajero
{
    partial class FormRegisterDebitCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegisterDebitCard));
            txtCardHolderName = new TextBox();
            txtCardNumber = new TextBox();
            txtPasswordCard = new TextBox();
            txtInitialBalance = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegisterDebitCard = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtCardHolderName
            // 
            txtCardHolderName.Anchor = AnchorStyles.None;
            txtCardHolderName.BackColor = Color.FromArgb(10, 10, 10);
            txtCardHolderName.BorderStyle = BorderStyle.FixedSingle;
            txtCardHolderName.ForeColor = Color.FromArgb(248, 248, 248);
            txtCardHolderName.Location = new Point(258, 165);
            txtCardHolderName.Name = "txtCardHolderName";
            txtCardHolderName.Size = new Size(258, 23);
            txtCardHolderName.TabIndex = 12;
            // 
            // txtCardNumber
            // 
            txtCardNumber.Anchor = AnchorStyles.None;
            txtCardNumber.BackColor = Color.FromArgb(10, 10, 10);
            txtCardNumber.BorderStyle = BorderStyle.FixedSingle;
            txtCardNumber.ForeColor = Color.FromArgb(248, 248, 248);
            txtCardNumber.Location = new Point(258, 214);
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(258, 23);
            txtCardNumber.TabIndex = 13;
            // 
            // txtPasswordCard
            // 
            txtPasswordCard.Anchor = AnchorStyles.None;
            txtPasswordCard.BackColor = Color.FromArgb(10, 10, 10);
            txtPasswordCard.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordCard.ForeColor = Color.FromArgb(248, 248, 248);
            txtPasswordCard.Location = new Point(258, 256);
            txtPasswordCard.Name = "txtPasswordCard";
            txtPasswordCard.Size = new Size(258, 23);
            txtPasswordCard.TabIndex = 14;
            // 
            // txtInitialBalance
            // 
            txtInitialBalance.Anchor = AnchorStyles.None;
            txtInitialBalance.BackColor = Color.FromArgb(10, 10, 10);
            txtInitialBalance.BorderStyle = BorderStyle.FixedSingle;
            txtInitialBalance.ForeColor = Color.FromArgb(248, 248, 248);
            txtInitialBalance.Location = new Point(258, 300);
            txtInitialBalance.Name = "txtInitialBalance";
            txtInitialBalance.Size = new Size(258, 23);
            txtInitialBalance.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(248, 248, 248);
            label1.Location = new Point(89, 169);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 16;
            label1.Text = "Nombre del titular:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(248, 248, 248);
            label2.Location = new Point(89, 214);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 17;
            label2.Text = "Número de tarjeta:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(248, 248, 248);
            label3.Location = new Point(89, 260);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 18;
            label3.Text = "Contraseña de la tarjeta:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(248, 248, 248);
            label4.Location = new Point(89, 304);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 19;
            label4.Text = "Monto inicial:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(248, 248, 248);
            label5.Location = new Point(260, 81);
            label5.Name = "label5";
            label5.Size = new Size(225, 33);
            label5.TabIndex = 20;
            label5.Text = "Registrar Tarjeta Débito";
            // 
            // btnRegisterDebitCard
            // 
            btnRegisterDebitCard.Anchor = AnchorStyles.None;
            btnRegisterDebitCard.BackColor = Color.FromArgb(1, 1, 1);
            btnRegisterDebitCard.Cursor = Cursors.Hand;
            btnRegisterDebitCard.FlatStyle = FlatStyle.Popup;
            btnRegisterDebitCard.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegisterDebitCard.ForeColor = Color.FromArgb(254, 242, 0);
            btnRegisterDebitCard.Location = new Point(347, 357);
            btnRegisterDebitCard.Name = "btnRegisterDebitCard";
            btnRegisterDebitCard.Size = new Size(79, 23);
            btnRegisterDebitCard.TabIndex = 21;
            btnRegisterDebitCard.Text = "Registrar";
            btnRegisterDebitCard.UseVisualStyleBackColor = false;
            btnRegisterDebitCard.Click += btnRegisterDebitCard_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(1, 1, 1);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(246, 150, 76);
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 22;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 354);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(508, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(38, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(216, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 25;
            pictureBox3.TabStop = false;
            // 
            // FormRegisterDebitCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 1, 1);
            ClientSize = new Size(684, 461);
            Controls.Add(pictureBox3);
            Controls.Add(btnExit);
            Controls.Add(btnRegisterDebitCard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtInitialBalance);
            Controls.Add(txtPasswordCard);
            Controls.Add(txtCardNumber);
            Controls.Add(txtCardHolderName);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "FormRegisterDebitCard";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCardHolderName;
        private TextBox txtCardNumber;
        private TextBox txtPasswordCard;
        private TextBox txtInitialBalance;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegisterDebitCard;
        private Button btnExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}