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
    public partial class FormStep2SelectAmount : Form
    {
        private readonly DebitCardService? debitCardService;
        private readonly NequiAccountService? nequiAccountService;
        private FormMain mainForm;
        private DebitCard? card;
        private NequiAccount? account;

        public FormStep2SelectAmount(FormMain form, DebitCard card)
        {
            InitializeComponent();
            mainForm = form;
            this.card = card;
            InitializeFormLabels();
            debitCardService = new DebitCardService(new DebitCardRepository());
            InactivityTimer.Start();
        }

        public FormStep2SelectAmount(FormMain form, NequiAccount account)
        {
            InitializeComponent();
            mainForm = form;
            this.account = account;
            InitializeFormLabels();
            nequiAccountService = new NequiAccountService(new NequiAccountRepository());
            InactivityTimer.Start();
        }

        private void InitializeFormLabels()
        {
            if (card != null)
            {
                label6.Text = card.CardHolderName.ToString();
                label8.Text = card.AvailableBalance.ToString();
            }
            else if (account != null)
            {
                label6.Text = account.AccountHolderName.ToString();
                label8.Text = account.AvailableBalance.ToString();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HandleWithdraw(int withdrawAmount)
        {
            try
            {
                // Verifica si estamos trabajando con una tarjeta de débito
                if (card != null && debitCardService != null)
                {
                    // Llama al servicio de tarjetas de débito
                    var response = debitCardService.WithdrawDebitCard(card, withdrawAmount);

                    MessageBox.Show(response.Message);

                    if (response.Success)
                    {
                        var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                        var mapBills = CalculateBills.CalculateBillsQuantity(withdrawAmount);
                        mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, withdrawAmount.ToString()));
                    }
                }
                // Verifica si estamos trabajando con una cuenta Nequi
                else if (account != null && nequiAccountService != null)
                {
                    // Llama al servicio de cuentas Nequi
                    var response = nequiAccountService.WithdrawNequiAccount(account, withdrawAmount);

                    MessageBox.Show(response.Message);

                    if (response.Success)
                    {
                        var updatedAccount = nequiAccountService.GetAccountByPhoneNumber(account.AccountNumber);
                        var mapBills = CalculateBills.CalculateBillsQuantity(withdrawAmount);
                        // hacer el el otro form reciba cuenta nequi
                        mainForm.openChildForm(new FormStep3Details(updatedAccount, mapBills, withdrawAmount.ToString()));
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo determinar el tipo de cuenta para realizar el retiro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }


        private void btn50000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(50_000);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            int amount;

            // Validar el monto inicial
            if (!int.TryParse(txtOther.Text, out amount))
            {
                MessageBox.Show("Por favor, ingrese un monto válido.");
                return;
            }

            if (amount % 10_000 != 0)
            {
                MessageBox.Show("Por favor, ingrese un monto múltiplo de 10.000");
                return;
            }

            HandleWithdraw(amount);
        }

        private void btn100_000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(100_000);
        }

        private void btn200_000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(200_000);
        }

        private void btn300_000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(300_000);
        }

        private void btn400_000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(400_000);
        }

        private void btn500_000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(500_000);
        }

        private void btn600_000_Click(object sender, EventArgs e)
        {
            HandleWithdraw(600_000);
        }

        private void FormStep2SelectAmount_FormClosing(object sender, FormClosingEventArgs e)
        {
            InactivityTimer.Stop();
        }

        private void InactivityTimer_Tick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                MessageBox.Show("Ha tardado demasiado tiempo en completar la transacción. Por favor, intente nuevamente.",
                                "Tiempo Excedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
