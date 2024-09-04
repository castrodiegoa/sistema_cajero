namespace GUI.Cajero.RetirarConTarjetaONequi
{
    partial class FormStep0SelectWithdrawalType
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStep0SelectWithdrawalType));
            radioBtnDebitCard = new RadioButton();
            radioBtnNequiAccount = new RadioButton();
            btnContinue = new Button();
            label1 = new Label();
            label2 = new Label();
            btnExit = new Button();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioBtnDebitCard
            // 
            radioBtnDebitCard.Anchor = AnchorStyles.None;
            radioBtnDebitCard.AutoSize = true;
            radioBtnDebitCard.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnDebitCard.ForeColor = Color.Black;
            radioBtnDebitCard.Location = new Point(233, 178);
            radioBtnDebitCard.Name = "radioBtnDebitCard";
            radioBtnDebitCard.Size = new Size(111, 26);
            radioBtnDebitCard.TabIndex = 0;
            radioBtnDebitCard.TabStop = true;
            radioBtnDebitCard.Text = "Tarjeta Débito";
            radioBtnDebitCard.UseVisualStyleBackColor = true;
            // 
            // radioBtnNequiAccount
            // 
            radioBtnNequiAccount.Anchor = AnchorStyles.None;
            radioBtnNequiAccount.AutoSize = true;
            radioBtnNequiAccount.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            radioBtnNequiAccount.ForeColor = Color.Black;
            radioBtnNequiAccount.Location = new Point(233, 229);
            radioBtnNequiAccount.Name = "radioBtnNequiAccount";
            radioBtnNequiAccount.Size = new Size(125, 26);
            radioBtnNequiAccount.TabIndex = 1;
            radioBtnNequiAccount.TabStop = true;
            radioBtnNequiAccount.Text = "Cuenta de Nequi";
            radioBtnNequiAccount.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            btnContinue.Anchor = AnchorStyles.None;
            btnContinue.BackColor = Color.FromArgb(0, 192, 0);
            btnContinue.FlatStyle = FlatStyle.Popup;
            btnContinue.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnContinue.ForeColor = Color.FromArgb(231, 234, 239);
            btnContinue.Location = new Point(306, 335);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(84, 23);
            btnContinue.TabIndex = 2;
            btnContinue.Text = "Anotación";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(224, 58);
            label1.Name = "label1";
            label1.Size = new Size(253, 33);
            label1.TabIndex = 3;
            label1.Text = "Seleccione el tipo de retiro";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(327, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 24);
            label2.TabIndex = 4;
            label2.Text = "Paso 0";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(231, 234, 239);
            btnExit.Location = new Point(306, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 23);
            btnExit.TabIndex = 41;
            btnExit.Text = "Cancelar";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // InactivityTimer
            // 
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // FormStep0SelectWithdrawalType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 239);
            ClientSize = new Size(684, 461);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnContinue);
            Controls.Add(radioBtnNequiAccount);
            Controls.Add(radioBtnDebitCard);
            Controls.Add(pictureBox1);
            Name = "FormStep0SelectWithdrawalType";
            Text = "FormStep0SelectWithdrawalType";
            FormClosing += FormStep0SelectWithdrawalType_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioBtnDebitCard;
        private RadioButton radioBtnNequiAccount;
        private Button btnContinue;
        private Label label1;
        private Label label2;
        private Button btnExit;
        private System.Windows.Forms.Timer InactivityTimer;
        private PictureBox pictureBox1;
    }
}