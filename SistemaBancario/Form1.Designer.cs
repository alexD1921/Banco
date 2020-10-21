namespace SistemaBancario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCodigoBanco = new System.Windows.Forms.Label();
            this.txtCodigoBanco = new System.Windows.Forms.TextBox();
            this.lbClave = new System.Windows.Forms.Label();
            this.lbCuenta = new System.Windows.Forms.Label();
            this.lbCodigoSucursal = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtCodigoSucursal = new System.Windows.Forms.TextBox();
            this.lbOrden = new System.Windows.Forms.Label();
            this.cmtOrden = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnConsulSaldo = new System.Windows.Forms.Button();
            this.btnDepocitar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCodigoBanco
            // 
            this.lbCodigoBanco.AutoSize = true;
            this.lbCodigoBanco.Location = new System.Drawing.Point(14, 6);
            this.lbCodigoBanco.Name = "lbCodigoBanco";
            this.lbCodigoBanco.Size = new System.Drawing.Size(95, 13);
            this.lbCodigoBanco.TabIndex = 0;
            this.lbCodigoBanco.Text = "Codigo de Banco: ";
            // 
            // txtCodigoBanco
            // 
            this.txtCodigoBanco.Location = new System.Drawing.Point(122, 3);
            this.txtCodigoBanco.Name = "txtCodigoBanco";
            this.txtCodigoBanco.Size = new System.Drawing.Size(202, 20);
            this.txtCodigoBanco.TabIndex = 1;
            // 
            // lbClave
            // 
            this.lbClave.AutoSize = true;
            this.lbClave.Location = new System.Drawing.Point(25, 84);
            this.lbClave.Name = "lbClave";
            this.lbClave.Size = new System.Drawing.Size(84, 13);
            this.lbClave.TabIndex = 2;
            this.lbClave.Text = "Clave Personal: ";
            this.lbClave.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbCuenta
            // 
            this.lbCuenta.AutoSize = true;
            this.lbCuenta.Location = new System.Drawing.Point(32, 60);
            this.lbCuenta.Name = "lbCuenta";
            this.lbCuenta.Size = new System.Drawing.Size(77, 13);
            this.lbCuenta.TabIndex = 3;
            this.lbCuenta.Text = "N° de Cuenta: ";
            // 
            // lbCodigoSucursal
            // 
            this.lbCodigoSucursal.AutoSize = true;
            this.lbCodigoSucursal.Location = new System.Drawing.Point(7, 32);
            this.lbCodigoSucursal.Name = "lbCodigoSucursal";
            this.lbCodigoSucursal.Size = new System.Drawing.Size(102, 13);
            this.lbCodigoSucursal.TabIndex = 4;
            this.lbCodigoSucursal.Text = "Codigo de Sucursal:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(122, 81);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(202, 20);
            this.txtClave.TabIndex = 5;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(122, 55);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(202, 20);
            this.txtCuenta.TabIndex = 6;
            // 
            // txtCodigoSucursal
            // 
            this.txtCodigoSucursal.Location = new System.Drawing.Point(122, 29);
            this.txtCodigoSucursal.Name = "txtCodigoSucursal";
            this.txtCodigoSucursal.Size = new System.Drawing.Size(202, 20);
            this.txtCodigoSucursal.TabIndex = 7;
            // 
            // lbOrden
            // 
            this.lbOrden.AutoSize = true;
            this.lbOrden.Location = new System.Drawing.Point(70, 110);
            this.lbOrden.Name = "lbOrden";
            this.lbOrden.Size = new System.Drawing.Size(39, 13);
            this.lbOrden.TabIndex = 8;
            this.lbOrden.Text = "Orden:";
            // 
            // cmtOrden
            // 
            this.cmtOrden.FormattingEnabled = true;
            this.cmtOrden.Items.AddRange(new object[] {
            "Movimientos",
            "Talonario"});
            this.cmtOrden.Location = new System.Drawing.Point(122, 107);
            this.cmtOrden.Name = "cmtOrden";
            this.cmtOrden.Size = new System.Drawing.Size(202, 21);
            this.cmtOrden.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(249, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(10, 159);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(314, 146);
            this.txtResult.TabIndex = 12;
            this.txtResult.Text = "";
            // 
            // btnConsulSaldo
            // 
            this.btnConsulSaldo.Location = new System.Drawing.Point(149, 134);
            this.btnConsulSaldo.Name = "btnConsulSaldo";
            this.btnConsulSaldo.Size = new System.Drawing.Size(94, 23);
            this.btnConsulSaldo.TabIndex = 13;
            this.btnConsulSaldo.Text = "Consultar saldo";
            this.btnConsulSaldo.UseVisualStyleBackColor = true;
            this.btnConsulSaldo.Click += new System.EventHandler(this.btnConsulSaldo_Click);
            // 
            // btnDepocitar
            // 
            this.btnDepocitar.Location = new System.Drawing.Point(249, 312);
            this.btnDepocitar.Name = "btnDepocitar";
            this.btnDepocitar.Size = new System.Drawing.Size(75, 23);
            this.btnDepocitar.TabIndex = 14;
            this.btnDepocitar.Text = "Depocitar";
            this.btnDepocitar.UseVisualStyleBackColor = true;
            this.btnDepocitar.Click += new System.EventHandler(this.btnDepocitar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(168, 312);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 23);
            this.btnRetirar.TabIndex = 15;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 347);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDepocitar);
            this.Controls.Add(this.btnConsulSaldo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmtOrden);
            this.Controls.Add(this.lbOrden);
            this.Controls.Add(this.txtCodigoSucursal);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lbCodigoSucursal);
            this.Controls.Add(this.lbCuenta);
            this.Controls.Add(this.lbClave);
            this.Controls.Add(this.txtCodigoBanco);
            this.Controls.Add(this.lbCodigoBanco);
            this.Name = "Form1";
            this.Text = "Sistema Bancario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoBanco;
        private System.Windows.Forms.TextBox txtCodigoBanco;
        private System.Windows.Forms.Label lbClave;
        private System.Windows.Forms.Label lbCuenta;
        private System.Windows.Forms.Label lbCodigoSucursal;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtCodigoSucursal;
        private System.Windows.Forms.Label lbOrden;
        private System.Windows.Forms.ComboBox cmtOrden;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnConsulSaldo;
        private System.Windows.Forms.Button btnDepocitar;
        private System.Windows.Forms.Button btnRetirar;
    }
}

