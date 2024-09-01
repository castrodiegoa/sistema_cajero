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
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(321, 51);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 49;
            label1.Text = "Paso 1";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 48;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnGetInto
            // 
            btnGetInto.Anchor = AnchorStyles.Bottom;
            btnGetInto.Location = new Point(321, 356);
            btnGetInto.Name = "btnGetInto";
            btnGetInto.Size = new Size(75, 23);
            btnGetInto.TabIndex = 47;
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
            label5.Size = new Size(156, 15);
            label5.TabIndex = 46;
            label5.Text = "Retirar con Cuenta de Nequi";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.ForeColor = Color.Gainsboro;
            label3.Location = new Point(86, 245);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 45;
            label3.Text = "Contraseña:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(86, 203);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 44;
            label2.Text = "Número de teléfono:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(254, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 23);
            txtPassword.TabIndex = 43;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(254, 195);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(258, 23);
            txtPhoneNumber.TabIndex = 42;
            // 
            // txtDynamicKey
            // 
            txtDynamicKey.Anchor = AnchorStyles.None;
            txtDynamicKey.BorderStyle = BorderStyle.FixedSingle;
            txtDynamicKey.Location = new Point(254, 276);
            txtDynamicKey.Name = "txtDynamicKey";
            txtDynamicKey.Size = new Size(258, 23);
            txtDynamicKey.TabIndex = 50;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.ForeColor = Color.Gainsboro;
            label4.Location = new Point(86, 284);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 51;
            label4.Text = "Clave dinámica:";
            // 
            // InactivityTimer
            // 
            InactivityTimer.Interval = 30000;
            InactivityTimer.Tick += InactivityTimer_Tick;
            // 
            // FormStep1LoginNequiAccountATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 461);
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
    }
}