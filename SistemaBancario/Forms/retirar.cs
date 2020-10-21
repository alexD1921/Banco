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
    
    public partial class retirar : Form
    {
        private Autenticar.SecurityAutSoapClient security;
        public retirar()
        {
            InitializeComponent();
            security = new Autenticar.SecurityAutSoapClient();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Autenticar.AuthUser user = new Autenticar.AuthUser();
            user.Saldo = txtMonto.Text;
            user.id_Usuario = txtp.Text;
            string x = security.Retirar(user);
            if (x.StartsWith("R")){
                MessageBox.Show(x);
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(x);
            }
        }
    }
}
