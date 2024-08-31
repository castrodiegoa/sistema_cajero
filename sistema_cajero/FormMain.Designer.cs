namespace sistema_cajero
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelSlideMenu = new Panel();
            panelAboutSubmenu = new Panel();
            btnAboutNequi = new Button();
            btnAboutManageDebitCard = new Button();
            btnAboutAtm = new Button();
            btnAbout = new Button();
            panelNequiSubmenu = new Panel();
            btnLoginNequi = new Button();
            btnRegisterNequi = new Button();
            btnNequi = new Button();
            panelManageDebitCardSubmenu = new Panel();
            btnRechargeDebitCard = new Button();
            btnRegisterDebitCard = new Button();
            btnManageDebitCard = new Button();
            panelAtmSubmenu = new Panel();
            btnWithdrawWithNequi = new Button();
            btnWithdrawWithCreditCard = new Button();
            btnAtm = new Button();
            panelLogo = new Panel();
            panelHour = new Panel();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            panelSlideMenu.SuspendLayout();
            panelAboutSubmenu.SuspendLayout();
            panelNequiSubmenu.SuspendLayout();
            panelManageDebitCardSubmenu.SuspendLayout();
            panelAtmSubmenu.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSlideMenu
            // 
            panelSlideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSlideMenu.Controls.Add(panelAboutSubmenu);
            panelSlideMenu.Controls.Add(btnAbout);
            panelSlideMenu.Controls.Add(panelNequiSubmenu);
            panelSlideMenu.Controls.Add(btnNequi);
            panelSlideMenu.Controls.Add(panelManageDebitCardSubmenu);
            panelSlideMenu.Controls.Add(btnManageDebitCard);
            panelSlideMenu.Controls.Add(panelAtmSubmenu);
            panelSlideMenu.Controls.Add(btnAtm);
            panelSlideMenu.Controls.Add(panelLogo);
            panelSlideMenu.Dock = DockStyle.Left;
            panelSlideMenu.Location = new Point(0, 0);
            panelSlideMenu.Name = "panelSlideMenu";
            panelSlideMenu.Size = new Size(250, 561);
            panelSlideMenu.TabIndex = 0;
            // 
            // panelAboutSubmenu
            // 
            panelAboutSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelAboutSubmenu.Controls.Add(btnAboutNequi);
            panelAboutSubmenu.Controls.Add(btnAboutManageDebitCard);
            panelAboutSubmenu.Controls.Add(btnAboutAtm);
            panelAboutSubmenu.Dock = DockStyle.Top;
            panelAboutSubmenu.Location = new Point(0, 535);
            panelAboutSubmenu.Name = "panelAboutSubmenu";
            panelAboutSubmenu.Size = new Size(250, 130);
            panelAboutSubmenu.TabIndex = 7;
            // 
            // btnAboutNequi
            // 
            btnAboutNequi.Dock = DockStyle.Top;
            btnAboutNequi.FlatAppearance.BorderSize = 0;
            btnAboutNequi.FlatStyle = FlatStyle.Flat;
            btnAboutNequi.ForeColor = Color.Gainsboro;
            btnAboutNequi.Location = new Point(0, 80);
            btnAboutNequi.Name = "btnAboutNequi";
            btnAboutNequi.Padding = new Padding(35, 0, 0, 0);
            btnAboutNequi.Size = new Size(250, 40);
            btnAboutNequi.TabIndex = 3;
            btnAboutNequi.Text = "Nequi";
            btnAboutNequi.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutNequi.UseVisualStyleBackColor = true;
            btnAboutNequi.Click += btnAboutNequi_Click;
            // 
            // btnAboutManageDebitCard
            // 
            btnAboutManageDebitCard.Dock = DockStyle.Top;
            btnAboutManageDebitCard.FlatAppearance.BorderSize = 0;
            btnAboutManageDebitCard.FlatStyle = FlatStyle.Flat;
            btnAboutManageDebitCard.ForeColor = Color.Gainsboro;
            btnAboutManageDebitCard.Location = new Point(0, 40);
            btnAboutManageDebitCard.Name = "btnAboutManageDebitCard";
            btnAboutManageDebitCard.Padding = new Padding(35, 0, 0, 0);
            btnAboutManageDebitCard.Size = new Size(250, 40);
            btnAboutManageDebitCard.TabIndex = 2;
            btnAboutManageDebitCard.Text = "Gestionar Tarjeta Débito";
            btnAboutManageDebitCard.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutManageDebitCard.UseVisualStyleBackColor = true;
            btnAboutManageDebitCard.Click += btnAboutManageDebitCard_Click;
            // 
            // btnAboutAtm
            // 
            btnAboutAtm.Dock = DockStyle.Top;
            btnAboutAtm.FlatAppearance.BorderSize = 0;
            btnAboutAtm.FlatStyle = FlatStyle.Flat;
            btnAboutAtm.ForeColor = Color.Gainsboro;
            btnAboutAtm.Location = new Point(0, 0);
            btnAboutAtm.Name = "btnAboutAtm";
            btnAboutAtm.Padding = new Padding(35, 0, 0, 0);
            btnAboutAtm.Size = new Size(250, 40);
            btnAboutAtm.TabIndex = 1;
            btnAboutAtm.Text = "Cajero";
            btnAboutAtm.TextAlign = ContentAlignment.MiddleLeft;
            btnAboutAtm.UseVisualStyleBackColor = true;
            btnAboutAtm.Click += btnAboutAtm_Click;
            // 
            // btnAbout
            // 
            btnAbout.Dock = DockStyle.Top;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.ForeColor = Color.Gainsboro;
            btnAbout.Location = new Point(0, 490);
            btnAbout.Name = "btnAbout";
            btnAbout.Padding = new Padding(10, 0, 0, 0);
            btnAbout.Size = new Size(250, 45);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "Acerca de";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // panelNequiSubmenu
            // 
            panelNequiSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelNequiSubmenu.Controls.Add(btnLoginNequi);
            panelNequiSubmenu.Controls.Add(btnRegisterNequi);
            panelNequiSubmenu.Dock = DockStyle.Top;
            panelNequiSubmenu.Location = new Point(0, 405);
            panelNequiSubmenu.Name = "panelNequiSubmenu";
            panelNequiSubmenu.Size = new Size(250, 85);
            panelNequiSubmenu.TabIndex = 5;
            // 
            // btnLoginNequi
            // 
            btnLoginNequi.Dock = DockStyle.Top;
            btnLoginNequi.FlatAppearance.BorderSize = 0;
            btnLoginNequi.FlatStyle = FlatStyle.Flat;
            btnLoginNequi.ForeColor = Color.Gainsboro;
            btnLoginNequi.Location = new Point(0, 40);
            btnLoginNequi.Name = "btnLoginNequi";
            btnLoginNequi.Padding = new Padding(35, 0, 0, 0);
            btnLoginNequi.Size = new Size(250, 40);
            btnLoginNequi.TabIndex = 2;
            btnLoginNequi.Text = "Iniciar Sesión";
            btnLoginNequi.TextAlign = ContentAlignment.MiddleLeft;
            btnLoginNequi.UseVisualStyleBackColor = true;
            btnLoginNequi.Click += btnRechargeNequi_Click;
            // 
            // btnRegisterNequi
            // 
            btnRegisterNequi.Dock = DockStyle.Top;
            btnRegisterNequi.FlatAppearance.BorderSize = 0;
            btnRegisterNequi.FlatStyle = FlatStyle.Flat;
            btnRegisterNequi.ForeColor = Color.Gainsboro;
            btnRegisterNequi.Location = new Point(0, 0);
            btnRegisterNequi.Name = "btnRegisterNequi";
            btnRegisterNequi.Padding = new Padding(35, 0, 0, 0);
            btnRegisterNequi.Size = new Size(250, 40);
            btnRegisterNequi.TabIndex = 1;
            btnRegisterNequi.Text = "Registrarse";
            btnRegisterNequi.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterNequi.UseVisualStyleBackColor = true;
            btnRegisterNequi.Click += btnRegisterNequi_Click;
            // 
            // btnNequi
            // 
            btnNequi.Dock = DockStyle.Top;
            btnNequi.FlatAppearance.BorderSize = 0;
            btnNequi.FlatStyle = FlatStyle.Flat;
            btnNequi.ForeColor = Color.Gainsboro;
            btnNequi.Location = new Point(0, 360);
            btnNequi.Name = "btnNequi";
            btnNequi.Padding = new Padding(10, 0, 0, 0);
            btnNequi.Size = new Size(250, 45);
            btnNequi.TabIndex = 4;
            btnNequi.Text = "Gestionar Nequi";
            btnNequi.TextAlign = ContentAlignment.MiddleLeft;
            btnNequi.UseVisualStyleBackColor = true;
            btnNequi.Click += btnNequi_Click;
            // 
            // panelManageDebitCardSubmenu
            // 
            panelManageDebitCardSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelManageDebitCardSubmenu.Controls.Add(btnRechargeDebitCard);
            panelManageDebitCardSubmenu.Controls.Add(btnRegisterDebitCard);
            panelManageDebitCardSubmenu.Dock = DockStyle.Top;
            panelManageDebitCardSubmenu.Location = new Point(0, 275);
            panelManageDebitCardSubmenu.Name = "panelManageDebitCardSubmenu";
            panelManageDebitCardSubmenu.Size = new Size(250, 85);
            panelManageDebitCardSubmenu.TabIndex = 3;
            // 
            // btnRechargeDebitCard
            // 
            btnRechargeDebitCard.Dock = DockStyle.Top;
            btnRechargeDebitCard.FlatAppearance.BorderSize = 0;
            btnRechargeDebitCard.FlatStyle = FlatStyle.Flat;
            btnRechargeDebitCard.ForeColor = Color.Gainsboro;
            btnRechargeDebitCard.Location = new Point(0, 40);
            btnRechargeDebitCard.Name = "btnRechargeDebitCard";
            btnRechargeDebitCard.Padding = new Padding(35, 0, 0, 0);
            btnRechargeDebitCard.Size = new Size(250, 40);
            btnRechargeDebitCard.TabIndex = 2;
            btnRechargeDebitCard.Text = "Recargar";
            btnRechargeDebitCard.TextAlign = ContentAlignment.MiddleLeft;
            btnRechargeDebitCard.UseVisualStyleBackColor = true;
            btnRechargeDebitCard.Click += btnRechargeCreditCard_Click;
            // 
            // btnRegisterDebitCard
            // 
            btnRegisterDebitCard.Dock = DockStyle.Top;
            btnRegisterDebitCard.FlatAppearance.BorderSize = 0;
            btnRegisterDebitCard.FlatStyle = FlatStyle.Flat;
            btnRegisterDebitCard.ForeColor = Color.Gainsboro;
            btnRegisterDebitCard.Location = new Point(0, 0);
            btnRegisterDebitCard.Name = "btnRegisterDebitCard";
            btnRegisterDebitCard.Padding = new Padding(35, 0, 0, 0);
            btnRegisterDebitCard.Size = new Size(250, 40);
            btnRegisterDebitCard.TabIndex = 1;
            btnRegisterDebitCard.Text = "Registrar";
            btnRegisterDebitCard.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisterDebitCard.UseVisualStyleBackColor = true;
            btnRegisterDebitCard.Click += btnRegisterCreditCard_Click;
            // 
            // btnManageDebitCard
            // 
            btnManageDebitCard.Dock = DockStyle.Top;
            btnManageDebitCard.FlatAppearance.BorderSize = 0;
            btnManageDebitCard.FlatStyle = FlatStyle.Flat;
            btnManageDebitCard.ForeColor = Color.Gainsboro;
            btnManageDebitCard.Location = new Point(0, 230);
            btnManageDebitCard.Name = "btnManageDebitCard";
            btnManageDebitCard.Padding = new Padding(10, 0, 0, 0);
            btnManageDebitCard.Size = new Size(250, 45);
            btnManageDebitCard.TabIndex = 2;
            btnManageDebitCard.Text = "Gestionar Tarjeta Débito";
            btnManageDebitCard.TextAlign = ContentAlignment.MiddleLeft;
            btnManageDebitCard.UseVisualStyleBackColor = true;
            btnManageDebitCard.Click += btnManageDebitCard_Click;
            // 
            // panelAtmSubmenu
            // 
            panelAtmSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelAtmSubmenu.Controls.Add(btnWithdrawWithNequi);
            panelAtmSubmenu.Controls.Add(btnWithdrawWithCreditCard);
            panelAtmSubmenu.Dock = DockStyle.Top;
            panelAtmSubmenu.Location = new Point(0, 145);
            panelAtmSubmenu.Name = "panelAtmSubmenu";
            panelAtmSubmenu.Size = new Size(250, 85);
            panelAtmSubmenu.TabIndex = 1;
            // 
            // btnWithdrawWithNequi
            // 
            btnWithdrawWithNequi.Dock = DockStyle.Top;
            btnWithdrawWithNequi.FlatAppearance.BorderSize = 0;
            btnWithdrawWithNequi.FlatStyle = FlatStyle.Flat;
            btnWithdrawWithNequi.ForeColor = Color.Gainsboro;
            btnWithdrawWithNequi.Location = new Point(0, 40);
            btnWithdrawWithNequi.Name = "btnWithdrawWithNequi";
            btnWithdrawWithNequi.Padding = new Padding(35, 0, 0, 0);
            btnWithdrawWithNequi.Size = new Size(250, 40);
            btnWithdrawWithNequi.TabIndex = 2;
            btnWithdrawWithNequi.Text = "Retirar con Nequi";
            btnWithdrawWithNequi.TextAlign = ContentAlignment.MiddleLeft;
            btnWithdrawWithNequi.UseVisualStyleBackColor = true;
            btnWithdrawWithNequi.Click += btnWithdrawWithNequi_Click;
            // 
            // btnWithdrawWithCreditCard
            // 
            btnWithdrawWithCreditCard.Dock = DockStyle.Top;
            btnWithdrawWithCreditCard.FlatAppearance.BorderSize = 0;
            btnWithdrawWithCreditCard.FlatStyle = FlatStyle.Flat;
            btnWithdrawWithCreditCard.ForeColor = Color.Gainsboro;
            btnWithdrawWithCreditCard.Location = new Point(0, 0);
            btnWithdrawWithCreditCard.Name = "btnWithdrawWithCreditCard";
            btnWithdrawWithCreditCard.Padding = new Padding(35, 0, 0, 0);
            btnWithdrawWithCreditCard.Size = new Size(250, 40);
            btnWithdrawWithCreditCard.TabIndex = 1;
            btnWithdrawWithCreditCard.Text = "Retirar con Tarjeta de Crédito";
            btnWithdrawWithCreditCard.TextAlign = ContentAlignment.MiddleLeft;
            btnWithdrawWithCreditCard.UseVisualStyleBackColor = true;
            btnWithdrawWithCreditCard.Click += btnWithdrawWithCreditCard_Click;
            // 
            // btnAtm
            // 
            btnAtm.Dock = DockStyle.Top;
            btnAtm.FlatAppearance.BorderSize = 0;
            btnAtm.FlatStyle = FlatStyle.Flat;
            btnAtm.ForeColor = Color.Gainsboro;
            btnAtm.Location = new Point(0, 100);
            btnAtm.Name = "btnAtm";
            btnAtm.Padding = new Padding(10, 0, 0, 0);
            btnAtm.Size = new Size(250, 45);
            btnAtm.TabIndex = 1;
            btnAtm.Text = "Cajero";
            btnAtm.TextAlign = ContentAlignment.MiddleLeft;
            btnAtm.UseVisualStyleBackColor = true;
            btnAtm.Click += btnAtm_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 100);
            panelLogo.TabIndex = 1;
            // 
            // panelHour
            // 
            panelHour.BackColor = Color.FromArgb(23, 21, 32);
            panelHour.Dock = DockStyle.Bottom;
            panelHour.Location = new Point(250, 461);
            panelHour.Name = "panelHour";
            panelHour.Size = new Size(684, 100);
            panelHour.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(684, 461);
            panelChildForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(144, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(414, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panelChildForm);
            Controls.Add(panelHour);
            Controls.Add(panelSlideMenu);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            MinimumSize = new Size(950, 600);
            Name = "FormMain";
            Text = "Form1";
            panelSlideMenu.ResumeLayout(false);
            panelAboutSubmenu.ResumeLayout(false);
            panelNequiSubmenu.ResumeLayout(false);
            panelManageDebitCardSubmenu.ResumeLayout(false);
            panelAtmSubmenu.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSlideMenu;
        private Panel panelAtmSubmenu;
        private Button btnWithdrawWithCreditCard;
        private Button btnAtm;
        private Panel panelLogo;
        private Button btnWithdrawWithNequi;
        private Button btnNequi;
        private Panel panelManageDebitCardSubmenu;
        private Button btnRechargeDebitCard;
        private Button btnRegisterDebitCard;
        private Button btnManageDebitCard;
        private Panel panelNequiSubmenu;
        private Button btnLoginNequi;
        private Button btnRegisterNequi;
        private Button btnAbout;
        private Panel panelAboutSubmenu;
        private Button btnAboutNequi;
        private Button btnAboutManageDebitCard;
        private Button btnAboutAtm;
        private Panel panelHour;
        private Panel panelChildForm;
        private PictureBox pictureBox1;
    }
}