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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Cajero.RetirarConTarjetaONequi
{
    public partial class FormStep1LoginNequiAccountATM : Form
    {
        private FormMain mainForm;
        private readonly NequiAccountService nequiAccountService;

        public FormStep1LoginNequiAccountATM(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
            this.nequiAccountService = new NequiAccountService(new NequiAccountRepository());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetInto_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;
            string dynamicKey = txtDynamicKey.Text;

            try
            {
                // Validar campos vacios
                var validation = ValidationHelper.ValidateNotEmpty(phoneNumber, password, dynamicKey);
                if (!validation)
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos estén completos.");
                    return;
                }

                // Validar número de telefono
                if (!ValidationHelper.IsPhoneNumberValid(phoneNumber))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido. (10 dígitos)");
                    return;
                }

                // Validad clave dinamica
                if (!ValidationHelper.IsDynamicKeyValid(dynamicKey))
                {
                    MessageBox.Show("Por favor, ingrese una clave dinámica válida. (6 dígitos)");
                    return;
                }

                // Loguear la nequi en la base de datos y validar clave dinamica
                var response = nequiAccountService.AuntenticatWithDynamicKey(phoneNumber, password, dynamicKey);

                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    var account = nequiAccountService.GetAccountByPhoneNumber(phoneNumber);
                    // Validar que el sig form permita nequi y tarjeta
                    mainForm.openChildForm(new FormStep2SelectAmount(mainForm, account));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}
