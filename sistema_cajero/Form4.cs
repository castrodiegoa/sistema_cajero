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
    public partial class Form4 : Form
    {
        private Form1 mainForm;

        public Form4(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGetInto_Click(object sender, EventArgs e)
        {
            mainForm.openChildForm(new Form5(mainForm));
        }


    }
}
