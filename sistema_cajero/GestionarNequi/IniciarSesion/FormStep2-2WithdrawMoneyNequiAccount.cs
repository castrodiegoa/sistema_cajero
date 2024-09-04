﻿using BLL;
using DAL;
using Entities;
using Entities.Utils;
using sistema_cajero;
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

namespace GUI.GestionarNequi.IniciarSesion
{
    public partial class FormStep2_2WithdrawMoneyNequiAccount : Form
    {
        private FormMain mainForm;
        private NequiAccount nequiAccount;
        private readonly NequiAccountService nequiAccountService;
        private string futureDate;

        public FormStep2_2WithdrawMoneyNequiAccount(FormMain form, NequiAccount nequiAccount, string futureDate)
        {
            InitializeComponent();
            mainForm = form;
            this.nequiAccount = nequiAccount;
            nequiAccountService = new NequiAccountService(new NequiAccountRepository());
            this.futureDate = futureDate;
            InitializeForm();
        }

        private async void InitializeForm()
        {
            label2.Text = nequiAccount.DynamicKey;
            label5.Text = futureDate;
            await Task.Delay(60000); // Tiempo antes de eliminar la clave dinámica

            var deleteDynamicKey = nequiAccountService.DeleteDinamicKeyToNequiAccount(nequiAccount);

            if (deleteDynamicKey.Success)
            {
                MessageBox.Show(deleteDynamicKey.Message);

            }
            else
            {
                MessageBox.Show("Error al desactivar la clave dinámica.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.openChildForm(new FormStep2DashboardNequi(mainForm, nequiAccount));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
