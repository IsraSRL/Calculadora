using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmContador : Form
    {
        int contador = 0;
        public frmContador()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tkbVelocidad.Enabled = true;
            tmrContador.Enabled = true;
            tmrContador.Interval = tkbVelocidad.Value * 200;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            tmrContador.Enabled = false;
            tkbVelocidad.Enabled = false;
        }

        private void tkbVelocidad_Scroll(object sender, EventArgs e)
        {
            tmrContador.Interval = tkbVelocidad.Value * 200;
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            contador++;
            lblCuenta.Text = contador.ToString();
        }
    }
}
