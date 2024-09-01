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

namespace GUI.GestionarNequi.IniciarSesion
{
    public partial class FormStep1LoginNequi : Form
    {
        private FormMain mainForm;
        private readonly NequiAccountService nequiAccountService;

        public FormStep1LoginNequi(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
            nequiAccountService = new NequiAccountService(new NequiAccountRepository());
        }

        private void btnGetInto_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtPhoneNumber.Text;
            string password = txtPassword.Text;

            try
            {
                // Validar campos vacios
                var validation = ValidationHelper.ValidateNotEmpty(phoneNumber, password);
                if (!validation)
                {
                    MessageBox.Show("Por favor, asegúrese de que todos los campos estén completos.");
                    return;
                }

                // Validar número de tarjeta
                if (!ValidationHelper.IsPhoneNumberValid(phoneNumber))
                {
                    MessageBox.Show("Por favor, ingrese un número de teléfono válido. (10 dígitos)");
                    return;
                }

                // Loguear la tarjeta en la base de datos
                var response = nequiAccountService.AuthenticateNequiAccount(phoneNumber, password);

                MessageBox.Show(response.Message);
                if (response.Success)
                {
                    var account = nequiAccountService.GetAccountByPhoneNumber(phoneNumber);
                    mainForm.openChildForm(new FormStep2DashboardNequi(mainForm, account));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex);
            }
        }
    }
}
