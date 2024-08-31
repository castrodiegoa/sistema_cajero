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
    public partial class FormStep2_2WithdrawMoneyNequiAccount : Form
    {
        private FormMain mainForm;
        private NequiAccount nequiAccount;

        public FormStep2_2WithdrawMoneyNequiAccount(FormMain form, NequiAccount nequiAccount)
        {
            InitializeComponent();
            mainForm = form;
            this.nequiAccount = nequiAccount;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Pasar nequiAccount con codigo/clave dinamica actualizad@
            mainForm.openChildForm(new FormStep2DashboardNequi(mainForm, nequiAccount));
        }
    }
}
