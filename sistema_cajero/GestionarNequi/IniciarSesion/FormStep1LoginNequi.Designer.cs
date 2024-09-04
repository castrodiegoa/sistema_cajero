namespace GUI.GestionarNequi.IniciarSesion
{
    partial class FormStep1LoginNequi
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
            btnExit = new Button();
            btnGetInto = new Button();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 234, 239);
            label1.Location = new Point(327, 54);
            label1.Name = "label1";
            label1.Size = new Size(47, 24);
            label1.TabIndex = 49;
            label1.Text = "Nequi";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(219, 0, 130);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.FromArgb(231, 234, 239);
            btnExit.Location = new Point(-1, -1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(33, 30);
            btnExit.TabIndex = 48;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnGetInto
            // 
            btnGetInto.Anchor = AnchorStyles.Bottom;
            btnGetInto.BackColor = Color.FromArgb(219, 0, 130);
            btnGetInto.Cursor = Cursors.Hand;
            btnGetInto.FlatStyle = FlatStyle.Popup;
            btnGetInto.Font = new Font("Bahnschrift Condensed", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGetInto.ForeColor = Color.FromArgb(231, 234, 239);
            btnGetInto.Location = new Point(228, 315);
            btnGetInto.Name = "btnGetInto";
            btnGetInto.Size = new Size(258, 23);
            btnGetInto.TabIndex = 47;
            btnGetInto.Text = "Entra";
            btnGetInto.UseVisualStyleBackColor = false;
            btnGetInto.Click += btnGetInto_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(231, 234, 239);
            label5.Location = new Point(289, 21);
            label5.Name = "label5";
            label5.Size = new Size(134, 33);
            label5.TabIndex = 46;
            label5.Text = "Iniciar Sesión";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(231, 234, 239);
            label3.Location = new Point(76, 231);
            label3.Name = "label3";
            label3.Size = new Size(46, 22);
            label3.TabIndex = 45;
            label3.Text = "Clave:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 234, 239);
            label2.Location = new Point(76, 195);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 44;
            label2.Text = "Número de teléfono:";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BackColor = Color.FromArgb(77, 51, 78);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(231, 234, 239);
            txtPassword.Location = new Point(228, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(258, 23);
            txtPassword.TabIndex = 43;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.BackColor = Color.FromArgb(77, 51, 78);
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtPhoneNumber.ForeColor = Color.FromArgb(231, 234, 239);
            txtPhoneNumber.Location = new Point(228, 195);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(258, 23);
            txtPhoneNumber.TabIndex = 42;
            // 
            // FormStep1LoginNequi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 0, 26);
            ClientSize = new Size(684, 461);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnGetInto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Name = "FormStep1LoginNequi";
            Text = "FormDashboardNequi";
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
    }
}