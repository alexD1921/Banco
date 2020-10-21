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
    public partial class CrearCuenta : Form
    {
        Autenticar.SecurityAutSoapClient client;
        public CrearCuenta()
        {
            InitializeComponent();
            client = new Autenticar.SecurityAutSoapClient();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Autenticar.AuthUser user = new Autenticar.AuthUser();
            var nombre=txtNewUsuario.Text;
            var cuenta = txtCuenta.Text;
            var contraseña = txtPassword.Text;
            var telefono = txtTelefono.Text;
            var saldo =txtSaldo.Text;
            user.NombreUsuario = nombre;
            user.NombreCuenta = cuenta;
            user.Contraseña = contraseña;
            user.NumTelefono = telefono;
            user.Saldo = saldo;
            string x = client.Registrar(user);

            if (x.StartsWith("R"))
            {
                Login login = new Login();
                login.Visible = true;
                this.Visible = false;
                MessageBox.Show(x);
            }
            else
            {
                MessageBox.Show(x);
            }

           
        }
    }
}
