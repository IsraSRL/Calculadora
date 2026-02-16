using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculadora.Formularios
{
    public partial class frmXMLAccess : Form
    {
        public frmXMLAccess()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("Directorio");

            
            for (int i = 0; i < dgvPersonas.Rows.Count; i++)
            {
                xml.Add(
                    new XElement("Personas"),
                    new XAttribute("id", dgvPersonas.Rows[i].Cells[0].Value),
                    new XElement("Nombre", dgvPersonas.Rows[i].Cells[1].Value),
                    new XElement ("Telefono", dgvPersonas.Rows[i].Cells[2].Value)
                    );
            }

            xml.Save("archivo.xml");
        }
    }
}
