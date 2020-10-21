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
    public partial class Id : Form
    {
        private Autenticar.SecurityAutSoapClient client;
        public Id()
        {
            InitializeComponent();
            client = new Autenticar.SecurityAutSoapClient();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
    }
}
