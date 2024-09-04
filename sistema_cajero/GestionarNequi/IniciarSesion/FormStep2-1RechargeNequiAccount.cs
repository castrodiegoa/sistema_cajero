using BLL;
using DAL;
using Entities;
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

namespace GUI.GestionarNequi.IniciarSesion
{
    public partial class FormStep3RechargeNequiAccount : Form
    {
        private FormMain mainForm;
        private NequiAccount nequiAccount;
        private readonly NequiAccountService nequiAccountService;

        public FormStep3RechargeNequiAccount(FormMain form, NequiAccount account)
        {
            InitializeComponent();
            this.mainForm = form;
            this.nequiAccount = account;
            nequiAccountService = new NequiAccountService(new NequiAccountRepository());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            // Pasar nequiAccount con nuevo monto actualizado
            var updatedNequiAccount = nequiAccountService.GetAccountByPhoneNumber(nequiAccount.AccountNumber);
            mainForm.openChildForm(new FormStep2DashboardNequi(mainForm, updatedNequiAccount));
        }

        private void btnRechargeNequiAccount_Click(object sender, EventArgs e)
        {
            decimal amount;
            try
            {

                // Validar el monto
                if (!decimal.TryParse(txtAmountToRecharge.Text, out amount))
                {
                    MessageBox.Show("Por favor, ingrese un monto válido.");
                    return;
                }


                var response = nequiAccountService.RechargeNequiAccount(nequiAccount.AccountNumber, amount);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    txtAmountToRecharge.Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
