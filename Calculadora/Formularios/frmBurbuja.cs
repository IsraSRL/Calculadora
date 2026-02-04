using Calculadora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmBurbuja : Form
    {
        public frmBurbuja()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] ordenado = new int[dgvDesrdenado.RowCount-1];
            Ordenamientos ordenar = new Ordenamientos();

            for (int i = 0; i < dgvDesrdenado.RowCount-1; i++)
            {
                ordenado[i] = Convert.ToInt32(dgvDesrdenado.Rows[i].Cells[0].Value);
            }

            ordenado = ordenar.Burbuja(ordenado);

            // define el tamaño de ordenado
            dgvOrdenado.DataSource = ordenado;

            //llena el dataGridView con los datos 
            for (int i = 0; i < ordenado.Length; i++)
            {
                dgvOrdenado.Rows[i].Cells[0].Value = ordenado[i];
            }

        }
    }
}
