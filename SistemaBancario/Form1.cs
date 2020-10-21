using SistemaBancario.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancario
{
    public partial class Form1 : Form
    {
        private Autenticar.SecurityAutSoapClient service;
        private ServicioBancario.BancoServiceSoapClient ServBan;
        public Form1()
        {
            InitializeComponent();
            ServBan = new ServicioBancario.BancoServiceSoapClient();
            service = new Autenticar.SecurityAutSoapClient();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ServicioBancario.BancoServiceSoapClient SB =
                new ServicioBancario.BancoServiceSoapClient();
            
            if (SB.codigoBanco(int.Parse(txtCodigoBanco.Text)))
            {
                MessageBox.Show("El valor del codigo del banco es erroneo");
            }

            if (SB.codigoSucursal(int.Parse(txtCodigoSucursal.Text)))
            {
                MessageBox.Show("El valor del codigo de la Sucursal es erroneo");
            }

            if (SB.numeroCuenta(int.Parse(txtCuenta.Text)))
            {
                MessageBox.Show("El Numero de Cuenta es erroneo");
            }
            if (SB.contraseña(txtClave.Text))
            {
                MessageBox.Show("La clave es erronea");
            }
            txtResult.Text= SB.orden(cmtOrden.Text);
        }
        public void Lista()
        {
            
        }

        private void btnDepocitar_Click(object sender, EventArgs e)
        {
            Autenticar.AuthUser user = new Autenticar.AuthUser();
            Depocitar depocitar = new Depocitar();
            depocitar.Visible = true;
            var x = service.getAcumulador();
            user.Saldo = x;
            string y = service.Retirar(user);
            
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            
            retirar retirar = new retirar();
            retirar.Visible = true;

        }

        private void btnConsulSaldo_Click(object sender, EventArgs e)
        {
            Id id = new Id();
            id.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
