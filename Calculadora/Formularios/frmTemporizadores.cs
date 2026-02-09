using Microsoft.VisualBasic;//para usar visualBasic
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;
using CSCore.SoundOut;

namespace Calculadora.Formularios
{
    public partial class frmTemporizadores : Form
    {
        string alarma1 = null;
        public frmTemporizadores()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            
            if(lblHora.Text == alarma1)
            {
                SoundPlayer alarma = new SoundPlayer(@"C:\Users\kevig\source\repos\Calculadora\Calculadora\Sonidos\dragon-studio-rooster-call-364474.wav");
                alarma.Play();

            }
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora: ", "Sistema", "00:00:00 x.x");
        }
    }
}
