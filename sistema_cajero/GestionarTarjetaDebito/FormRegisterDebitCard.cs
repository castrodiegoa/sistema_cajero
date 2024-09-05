using BLL;
using DAL;
using Entities;
using Entities.Utils;
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
    public partial class FormRegisterDebitCard : Form
    {
        private readonly DebitCardService debitCardService;

        public FormRegisterDebitCard()
        {
            InitializeComponent();
            debitCardService = new DebitCardService(new DebitCardRepository());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterDebitCard_Click(object sender, EventArgs e)
        {
            string cardHolderName = txtCardHolderName.Text;
            string cardNumber = txtCardNumber.Text;
            string password = txtPasswordCard.Text;
            decimal initialBalance;
            try
            {
                // Validar campos vacios
                var validation = ValidationHelper.ValidateNotEmpty(cardHolderName, cardNumber, password);
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

                // Validar número de tarjeta
                if (!ValidationHelper.IsCardNumberValid(cardNumber))
                {
                    MessageBox.Show("Por favor, ingrese un número de tarjeta válido. (16 dígitos)");
                    return;
                }

                // Crear la instancia de la tarjeta de débito
                DebitCard newCard = new DebitCard
                {
                    CardHolderName = cardHolderName,
                    CardNumber = cardNumber,
                    Password = password,
                    AvailableBalance = initialBalance,
                    CreationDate = DateTime.Now
                };

                // Registrar la tarjeta en la base de datos
                var response = debitCardService.AddDebitCard(newCard);

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
