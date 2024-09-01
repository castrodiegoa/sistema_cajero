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
    public partial class FormStep1LoginDebitCardATM : Form
    {
        private FormMain mainForm;
        private readonly DebitCardService debitCardService;

        public FormStep1LoginDebitCardATM(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
            debitCardService = new DebitCardService(new DebitCardRepository());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetInto_Click(object sender, EventArgs e)
        {
            string cardNumber = txtNumberCard.Text;
            string password = txtPasswordCard.Text;

            try
            {
                // Validar campos vacios
                var validation = ValidationHelper.ValidateNotEmpty(cardNumber, password);
                if (!validation)
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos estén completos.");
                    return;
                }

                // Validar número de tarjeta
                if (!ValidationHelper.IsCardNumberValid(cardNumber))
                {
                    MessageBox.Show("Por favor, ingrese un número de tarjeta válido. (11 dígitos)");
                    return;
                }

                // Loguear la tarjeta en la base de datos
                var response = debitCardService.AuthenticateDebitCard(cardNumber, password);

                MessageBox.Show(response.Message);
                if (response.Success) 
                {
                    var card = debitCardService.GetDebitCardByNumber(cardNumber);
                    mainForm.openChildForm(new FormStep2SelectAmount(mainForm, card));
                }

                // si la cuneta existe mirar la clave dinamica
                // Si es igual loguear
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }

            
        }


    }
}
