
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario.Forms
{
    public partial class Depocitar : Form
    {
        private Autenticar.SecurityAutSoapClient security;
        public Depocitar()
        {
            InitializeComponent();
            security = new Autenticar.SecurityAutSoapClient();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Autenticar.AuthUser user = new Autenticar.AuthUser();
            user.id_Usuario = txtId.Text;
            user.Saldo = txtMonto.Text;
            security.setAcumulador(txtMonto.Text);
            string x = security.Depocitar(user);
            MessageBox.Show(x);
            if (x.StartsWith("D"))
            {
                this.Visible = false;
            }
        }
    }
}
