namespace sistema_cajero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelAtmSubmenu.Visible = false;
            panelManageDebitCardSubmenu.Visible = false;
            panelNequiSubmenu.Visible = false;
            panelAboutSubmenu.Visible = false;
        }

        private void hideSubeMenu()
        {
            if (panelAtmSubmenu.Visible == true)
            {
                panelAtmSubmenu.Visible = false;
            }

            if (panelManageDebitCardSubmenu.Visible == true)
            {
                panelManageDebitCardSubmenu.Visible = false;
            }

            if (panelNequiSubmenu.Visible == true)
            {
                panelNequiSubmenu.Visible = false;
            }

            if (panelAboutSubmenu.Visible == true)
            {
                panelAboutSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubeMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        /*
         * Events button "Cajero"
         */
        private void btnAtm_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAtmSubmenu);
        }

        private void btnWithdrawWithCreditCard_Click(object sender, EventArgs e)
        {
            // code...
            openChildForm(new Form4(this));
            hideSubeMenu();
        }

        private void btnWithdrawWithNequi_Click(object sender, EventArgs e)
        {
            // code...
            hideSubeMenu();
        }

        /*
         * Events button "Gestionar Tarjeta D�bito"
         */
        private void btnManageDebitCard_Click(object sender, EventArgs e)
        {
            showSubMenu(panelManageDebitCardSubmenu);
        }

        private void btnRegisterCreditCard_Click(object sender, EventArgs e)
        {
            // code...
            openChildForm(new Form2());
            hideSubeMenu();
        }

        private void btnRechargeCreditCard_Click(object sender, EventArgs e)
        {
            // code...
            openChildForm(new Form3());
            hideSubeMenu();
        }

        /*
         * Events button "Nequi"
         */
        private void btnNequi_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNequiSubmenu);
        }

        private void btnRegisterNequi_Click(object sender, EventArgs e)
        {
            // code...
            hideSubeMenu();
        }

        private void btnRechargeNequi_Click(object sender, EventArgs e)
        {
            // code...
            hideSubeMenu();
        }

        /*
         * Events button "Acerca de"
         */
        private void btnAbout_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAboutSubmenu);
        }

        private void btnAboutAtm_Click(object sender, EventArgs e)
        {
            // code...
            hideSubeMenu();
        }

        private void btnAboutManageDebitCard_Click(object sender, EventArgs e)
        {
            // code...
            hideSubeMenu();
        }

        private void btnAboutNequi_Click(object sender, EventArgs e)
        {
            // code...
            hideSubeMenu();
        }


        #region Child Form
        #endregion
        public Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}