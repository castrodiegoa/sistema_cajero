using BLL;
using DAL;
using Entities;
using GUI.GestionarNequi.IniciarSesion;
using GUI.Nequi;
using sistema_cajero;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.GestionarNequi
{


    public partial class FormStep2DashboardNequi : Form
    {
        private FormMain mainForm;
        private NequiAccount nequiAccount;
        private readonly NequiAccountService nequiAccountService;

        public FormStep2DashboardNequi(FormMain form, NequiAccount account)
        {
            InitializeComponent();
            this.mainForm = form;
            this.nequiAccount = account;
            nequiAccountService = new NequiAccountService(new NequiAccountRepository());
            customizeDesing();
        }

        private void customizeDesing()
        {
            panelActionsNequiSubmenu.Visible = false;
            label2.Text = nequiAccount.AccountHolderName;
            label4.Text = nequiAccount.AvailableBalance.ToString();
        }



        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            showSubMenu(panelActionsNequiSubmenu);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Proceso de generar codigo o clave dinamica...
            var response = nequiAccountService.SaveDinamicKeyToNequiAccount(nequiAccount);

            if (!response.Success)
            {
                MessageBox.Show(response.Message);
                return;
            }

            var updatedAccount = nequiAccountService.GetAccountByPhoneNumber(nequiAccount.AccountNumber);
            mainForm.openChildForm(new FormStep2_2WithdrawMoneyNequiAccount(mainForm, updatedAccount));
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new FormStep3RechargeNequiAccount(mainForm, nequiAccount));
        }
    }
}
