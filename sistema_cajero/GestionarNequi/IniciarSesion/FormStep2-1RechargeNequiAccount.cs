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
    public partial class FormStep3RechargeNequiAccount : Form
    {
        private FormMain mainForm;
        private NequiAccount nequiAccount;

        public FormStep3RechargeNequiAccount(FormMain form, NequiAccount account)
        {   
            InitializeComponent();
            this.mainForm = form;
            this.nequiAccount = account;
        }

    }
}
