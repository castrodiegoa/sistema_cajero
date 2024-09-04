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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStep1LoginDebitCardATM));
            btnExit = new Button();
            btnGetInto = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPasswordCard = new TextBox();
            txtNumberCard = new TextBox();
            label1 = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(231, 234, 239);
            btnExit.Location = new Point(326, 306);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 23);
            btnExit.TabIndex = 40;
            btnExit.Text = "Cancelar";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnGetInto
            // 
            btnGetInto.Anchor = AnchorStyles.None;
            btnGetInto.BackColor = Color.FromArgb(0, 192, 0);
            btnGetInto.FlatStyle = FlatStyle.Popup;
            btnGetInto.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetInto.ForeColor = Color.FromArgb(231, 234, 239);
            btnGetInto.Location = new Point(326, 346);
            btnGetInto.Name = "btnGetInto";
            btnGetInto.Size = new Size(84, 23);
            btnGetInto.TabIndex = 39;
            btnGetInto.Text = "Anotación";
            btnGetInto.UseVisualStyleBackColor = false;
            btnGetInto.Click += btnGetInto_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(234, 58);
            label5.Name = "label5";
            label5.Size = new Size(240, 33);
            label5.TabIndex = 38;
            label5.Text = "Retirar con Tarjeta Débito";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(80, 237);
            label3.Name = "label3";
            label3.Size = new Size(148, 21);
            label3.TabIndex = 37;
            label3.Text = "Contraseña de la tarjeta:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 195);
            label2.Name = "label2";
            label2.Size = new Size(115, 21);
            label2.TabIndex = 36;
            label2.Text = "Número de tarjeta:";
            // 
            // txtPasswordCard
            // 
            txtPasswordCard.Anchor = AnchorStyles.None;
            txtPasswordCard.BackColor = Color.FromArgb(224, 224, 224);
            txtPasswordCard.Location = new Point(254, 237);
            txtPasswordCard.Name = "txtPasswordCard";
            txtPasswordCard.Size = new Size(258, 23);
            txtPasswordCard.TabIndex = 35;
            // 
            // txtNumberCard
            // 
            txtNumberCard.Anchor = AnchorStyles.None;
            txtNumberCard.BackColor = Color.FromArgb(224, 224, 224);
            txtNumberCard.Location = new Point(254, 195);
            txtNumberCard.Name = "txtNumberCard";
            txtNumberCard.Size = new Size(258, 23);
            txtNumberCard.TabIndex = 34;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(335, 101);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 41;
            label1.Text = "Paso 1";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(47, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // FormStep1LoginDebitCardATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 239);
            ClientSize = new Size(684, 461);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnGetInto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPasswordCard);
            Controls.Add(txtNumberCard);
            Name = "FormStep1LoginDebitCardATM";
            Text = "Form4";
            FormClosing += FormStep1LoginDebitCardATM_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private System.Windows.Forms.Timer InactivityTimer;
        private PictureBox pictureBox1;
    }
}