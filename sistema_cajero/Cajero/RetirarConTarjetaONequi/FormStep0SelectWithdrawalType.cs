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
    public partial class FormStep0SelectWithdrawalType : Form
    {
        private FormMain mainForm;

        public FormStep0SelectWithdrawalType(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (radioBtnDebitCard.Checked == true)
            {
                mainForm.openChildForm(new FormStep1LoginDebitCardATM(mainForm));
            }
            else if (radioBtnNequiAccount.Checked == true)
            {
                mainForm.openChildForm(new FormStep1LoginNequiAccountATM(mainForm));
            }
            else
            {
                MessageBox.Show("Seleccione una opción antes de continuar.");
            }
        }
    }
}
