using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class frmRegistro : Form
    {
        List<Persona> personas = new List<Persona>();
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            personas.Add(new Persona()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Fecha = dtpFecha.Value
            });
            MessageBox.Show("Datos registrados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = personas;
                verificarRegistros();
            }
        }

        private void verificarRegistros()
        {
            if (personas.Count == 0)
                btnEliminar.Enabled = false;
            else
                btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            personas.RemoveAt(dgvPersonas.CurrentRow.Index);
            dgvPersonas.DataSource = null; //limpiar datagrid
            dgvPersonas.DataSource = personas; //volver a llenar el DGV
            verificarRegistros(); //verificar si se habilito el boton
        }
    }
}
