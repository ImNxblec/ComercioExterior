using ComercioExterior.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercioExterior.Views
{
    public partial class frmBuscador : Form
    {
        public string tipo = "";
        public string filtro = "";
        public string repuesta1 = "";
        public string repuesta2 = "";

        public frmBuscador()
        {
            InitializeComponent();
        }

        private void Buscador_Load(object sender, EventArgs e)
        {
            txtFiltro.Text = filtro;
            cargarGrid();
        }

        private void cargarGrid()
        {
            if (tipo == "C")
            {
                cargarCliente();
            }
            else if (tipo == "P")
            {
                cargarPuertos();
            }
        }

        private void cargarCliente()
        {
            var listaCliente = Utiles.contexto.Clientes.Where(x => x.Estado == "A" && (x.Cedula.ToUpper().Contains(txtFiltro.Text)
            || x.Nombres.ToUpper().Contains(txtFiltro.Text) || x.Apellidos.ToUpper().Contains(txtFiltro.Text) || x.Id.ToString().Contains(txtFiltro.Text))).ToList();

            grdDatos.DataSource = listaCliente;
        }

        private void cargarPuertos()
        {
            var listaPuerto = Utiles.contexto.Puertos.Where(x => x.Estado == "A" && (x.Descripcion.ToUpper().Contains(txtFiltro.Text)
            || x.Codigo.ToUpper().Contains(txtFiltro.Text) || x.Id.ToString().Contains(txtFiltro.Text))).ToList();
            grdDatos.DataSource = listaPuerto;

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            grabarSeleccion();
        }

        private void grabarSeleccion()
        {
            if (grdDatos.Rows.Count > 0)
            {
                repuesta1 = grdDatos.CurrentRow.Cells[0].Value.ToString();

                if (tipo == "C")
                {
                    repuesta2 = grdDatos.CurrentRow.Cells[2].Value.ToString() + " " + grdDatos.CurrentRow.Cells[3].Value.ToString();
                }
                else if (tipo == "P")
                {
                    repuesta2 = grdDatos.CurrentRow.Cells[1].Value.ToString() + "-" + grdDatos.CurrentRow.Cells[2].Value.ToString();

                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("No existen registros seleccionados.");
            }
        }

        private void grdDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grabarSeleccion();
        }

        private void grdDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grabarSeleccion();
        }
    }
}
