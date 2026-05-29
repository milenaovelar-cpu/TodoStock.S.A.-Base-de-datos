using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPOSCSharpMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FromVentas objetoFromVnetas = new Formularios.FromVentas();
            objetoFromVnetas.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FromClientes objetoFromVnetas = new Formularios.FromClientes();
            objetoFromVnetas.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FromProductos objetoFromVnetas = new Formularios.FromProductos();
            objetoFromVnetas.Show();
        }

        private void buscarComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FromBuscarComprobante objetoFromVnetas = new Formularios.FromBuscarComprobante();
            objetoFromVnetas.Show();
        }

        private void consultarPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FromReportePorFechas objetoFromVnetas = new Formularios.FromReportePorFechas();
            objetoFromVnetas.Show();
        }
    }
}
