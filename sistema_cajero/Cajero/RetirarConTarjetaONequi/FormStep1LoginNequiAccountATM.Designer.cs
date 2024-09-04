namespace GUI.Cajero.RetirarConTarjetaONequi
{
    partial class FormStep1LoginNequiAccountATM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStep1LoginNequiAccountATM));
            label1 = new Label();
            btnExit = new Button();
            btnGetInto = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            txtDynamicKey = new TextBox();
            label4 = new Label();
            InactivityTimer = new System.Windows.Forms.Timer(components);
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
            label1.Location = new Point(331, 103);
            label1.Name = "label1";
            label1.Size = new Size(51, 24);
            label1.TabIndex = 49;
            label1.Text = "Paso 1";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.BackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(231, 234, 239);
            btnExit.Location = new Point(331, 326);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(84, 23);
            btnExit.TabIndex = 48;
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
            btnGetInto.Location = new Point(331, 362);
            btnGetInto.Name = "btnGetInto";
            btnGetInto.Size = new Size(84, 23);
            btnGetInto.TabIndex = 47;
            btnGetInto.Text = "Ingresar";
            btnGetInto.UseVisualStyleBackColor = false;
            btnGetInto.Click += btnGetInto_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(229, 60);
            label5.Name = "label5";
            label5.Size = new Size(261, 33);
            label5.TabIndex = 46;
            label5.Text = "Retirar con Cuenta de Nequi";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(86, 235);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 45;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 196);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 44;
            label2.Text = "Número de teléfono:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(224, 224, 224);
            txtPassword.Location = new Point(254, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 23);
            txtPassword.TabIndex = 43;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.BackColor = Color.FromArgb(224, 224, 224);
            txtPhoneNumber.Location = new Point(254, 195);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(258, 23);
            txtPhoneNumber.TabIndex = 42;
            // 
            // txtDynamicKey
            // 
            txtDynamicKey.Anchor = AnchorStyles.None;
            txtDynamicKey.BackColor = Color.FromArgb(224, 224, 224);
            txtDynamicKey.Location = new Point(254, 276);
            txtDynamicKey.Name = "txtDynamicKey";
            txtDynamicKey.Size = new Size(258, 23);
            txtDynamicKey.TabIndex = 50;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(86, 277);
            label4.Name = "label4";
            label4.Size = new Size(105, 22);
            label4.TabIndex = 51;
            label4.Text = "Clave dinámica:";
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
            pictureBox1.Location = new Point(42, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // FormStep1LoginNequiAccountATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 234, 239);
            ClientSize = new Size(684, 461);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(txtDynamicKey);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnGetInto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Name = "FormStep1LoginNequiAccountATM";
            Text = "FormStep1LoginNequiAccountATM";
            FormClosing += FormStep1LoginNequiAccountATM_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnExit;
        private Button btnGetInto;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtPhoneNumber;
        private TextBox txtDynamicKey;
        private Label label4;
        private System.Windows.Forms.Timer InactivityTimer;
        private PictureBox pictureBox1;
    }
}