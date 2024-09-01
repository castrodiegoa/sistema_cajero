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
            InactivityTimer.Start();
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

        private void InactivityTimer_Tick_1(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                MessageBox.Show("Ha tardado demasiado tiempo en completar la transacción. Por favor, intente nuevamente.",
                                "Tiempo Excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void FormStep0SelectWithdrawalType_FormClosing(object sender, FormClosingEventArgs e)
        {
            InactivityTimer.Stop();
        }
    }
}
