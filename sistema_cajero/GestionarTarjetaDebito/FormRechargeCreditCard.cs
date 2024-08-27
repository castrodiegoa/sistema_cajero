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

namespace sistema_cajero
{
    public partial class FormRechargeCreditCard : Form
    {
        private readonly DebitCardService debitCardService;

        public FormRechargeCreditCard()
        {
            InitializeComponent();
            debitCardService = new DebitCardService(new DebitCardRepository());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRechargeDebitCard_Click(object sender, EventArgs e)
        {
            string cardNumber = txtNumberCard.Text;
            string password = txtPasswordCard.Text;
            decimal amount;
            try
            {
                // Validar campos vacios
                var validation = ValidationHelper.ValidateNotEmpty(cardNumber, password);
                if (!validation)
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos estén completos.");
                    return;
                }

                // Validar el monto inicial
                if (!decimal.TryParse(txtAmountToRecharge.Text, out amount))
                {
                    MessageBox.Show("Por favor, ingrese un monto válido.");
                    return;
                }             

                // Loguear la tarjeta en la base de datos
                var response = debitCardService.AuthenticateDebitCard(cardNumber, password);

                if (!response.Success)
                {
                    MessageBox.Show(response.Message);
                }
                else
                {
                    // ! Esta parte puede mejorar, para no hacer 2 response
                    var response2 = debitCardService.RechargeDebitCard(cardNumber, amount);
                    MessageBox.Show(response2.Message);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}
