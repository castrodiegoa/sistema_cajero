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
        private readonly DebitCardService debitCardService;
        private FormMain mainForm;
        private DebitCard card;


        public FormStep2SelectAmount(FormMain form, DebitCard card)
        {
            InitializeComponent();
            mainForm = form;
            this.card = card;
            InitializeFormLabels();
            debitCardService = new DebitCardService(new DebitCardRepository());
        }

        private void InitializeFormLabels()
        {
            label6.Text = card.CardHolderName.ToString();
            label8.Text = card.AvailableBalance.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn50000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 50000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(50_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "50.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }

        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            try
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

                var response = debitCardService.WithdrawDebitCard(card, amount);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(50_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, amount.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btn100_000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 100_000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(100_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "100.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btn200_000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 200_000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(200_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "200.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btn300_000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 300_000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(300_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "300.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btn400_000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 400_000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(400_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "400.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btn500_000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 500_000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(500_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "500.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void btn600_000_Click(object sender, EventArgs e)
        {
            try
            {
                var response = debitCardService.WithdrawDebitCard(card, 600_000);

                MessageBox.Show(response.Message);

                if (response.Success)
                {
                    var updatedCard = debitCardService.GetDebitCardByNumber(card.CardNumber);
                    var mapBills = CalculateBills.CalculateBillsQuantity(500_000);
                    mainForm.openChildForm(new FormStep3Details(updatedCard, mapBills, "600.000"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }
    }
}
