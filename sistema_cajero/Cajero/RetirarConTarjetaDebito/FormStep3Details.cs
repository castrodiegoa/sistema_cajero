using BLL;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cajero
{
    public partial class FormStep3Details : Form
    {
        private DebitCard card;
        Dictionary<int, int> mapBills;

        private string withdrawAmount;

        public FormStep3Details(DebitCard card, Dictionary<int, int> mapBills, string withdrawAmount)
        {
            InitializeComponent();
            this.card = card;
            this.mapBills = mapBills;
            InitializeFormLabels();
            this.withdrawAmount = withdrawAmount;

        }

        private void InitializeFormLabels()
        {
            label12.Text = withdrawAmount;
            label13.Text = card.AvailableBalance.ToString();
            label14.Text = card.CardHolderName.ToString();
            label15.Text = DateTime.Now.ToString("dd/MM/yyyy");

            label16.Text = mapBills[10_000].ToString();
            label17.Text = mapBills[20_000].ToString();
            label18.Text = mapBills[50_000].ToString();
            label19.Text = mapBills[100_000].ToString();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
