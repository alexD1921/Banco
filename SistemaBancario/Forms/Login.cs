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
    public partial class Login : Form
    {
        private Autenticar.SecurityAutSoapClient security;
        public Login()
        {
            InitializeComponent();
            security = new Autenticar.SecurityAutSoapClient();

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Autenticar.AuthUser user = new Autenticar.AuthUser();
            user.Contraseña = txtContraseña.Text.Trim().ToLower();
            user.NombreCuenta = txtUsuario.Text.Trim().ToLower();
            Form1 form1 = new Form1();
            String x = security.Autenticar(user);
            MessageBox.Show(x);
            if (x.StartsWith("B"))
            {
                form1.Visible = true;
                this.Visible = false;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CrearCuenta crearCuenta = new CrearCuenta();
            crearCuenta.Visible = true;
            this.Visible = false;
        }

        private void btnDepocito_Click(object sender, EventArgs e)
        {
            Depocitar depocitar = new Depocitar();
            depocitar.Visible = true;
        }
        public string A()
        {
            return txtUsuario.Text;
        }
        public string B()
        {
            return txtContraseña.Text;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
