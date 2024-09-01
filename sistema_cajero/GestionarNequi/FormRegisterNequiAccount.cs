using BLL;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Nequi
{
    public partial class FormRegisterNequiAccount : Form
    {
        private readonly NequiAccountService nequiAccountService;

        public FormRegisterNequiAccount()
        {
            InitializeComponent();
            nequiAccountService = new NequiAccountService(new NequiAccountRepository());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterNequiAccount_Click(object sender, EventArgs e)
        {
            string cardHolderName = txtCardHolderName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPasswordAccount.Text;
            decimal initialBalance;
            try
            {
                // Validar campos vacios
                var validation = ValidationHelper.ValidateNotEmpty(cardHolderName, phoneNumber, password);
                if (!validation)
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos estén completos.");
                    return;
                }

                // Validar el monto inicial
                if (!decimal.TryParse(txtInitialBalance.Text, out initialBalance))
                {
                    MessageBox.Show("Por favor, ingrese un monto inicial válido.");
                    return;
                }

                // Validar número de télefono
                if (!ValidationHelper.IsPhoneNumberValid(phoneNumber))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido. (10 dígitos)");
                    return;
                }

                // Crear la instancia
                NequiAccount newAccount = new NequiAccount
                {
                    AccountHolderName = cardHolderName,
                    AccountNumber = phoneNumber,
                    Password = password,
                    AvailableBalance = initialBalance,
                    CreationDate = DateTime.Now
                };

                // Registrar la tarjeta en la base de datos
                var response = nequiAccountService.AddNequiAccount(newAccount);

                MessageBox.Show(response.Message);
                if (response.Success) this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}
