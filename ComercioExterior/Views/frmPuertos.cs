using ComercioExterior.Context;
using ComercioExterior.Models;
using ComercioExterior.Views;
using Microsoft.IdentityModel.Tokens;
using System.Data.Common;

namespace ComercioExterior
{
    public partial class frmPuertos : Form
    {
        public frmPuertos()
        {
            InitializeComponent();
            Utiles.contexto = new Eff2Context();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmIndexComercioExterior indexForm = new frmIndexComercioExterior();
            indexForm.StartPosition = FormStartPosition.CenterScreen;
            indexForm.Show();
            this.Close();
        }

        private void frmPuertos_Load(object sender, EventArgs e)
        {
            var listaPuerto = Utiles.contexto.Puertos.ToList();
            grdPuertos.DataSource = listaPuerto;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoPuertos formulario = new frmMantenimientoPuertos();
            formulario.ShowDialog();
            var listaPuerto = Utiles.contexto.Puertos.ToList();
            grdPuertos.DataSource = listaPuerto;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            if (grdPuertos.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdPuertos.CurrentRow.Cells[0].Value);
                frmMantenimientoPuertos formulario = new frmMantenimientoPuertos();
                formulario.idPuerto = id;
                formulario.ShowDialog();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdPuertos.RowCount <= 0)
            {
                MessageBox.Show("No existen datos para eliminar.");
                return;
            }

            int idPuerto = Convert.ToInt32(grdPuertos.CurrentRow.Cells[0].Value); // Obtener el ID seleccionado

            var objPuerto = Utiles.contexto.Puertos.Find(idPuerto);
            if (objPuerto != null)
            {
                // Confirmación antes de eliminar
                var confirmResult = MessageBox.Show(
                    $"¿Estás seguro de eliminar el puerto {objPuerto.Estado}?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // Cambiar estado a "I" para marcarlo como inactivo
                    objPuerto.Estado = "I";
                    Utiles.contexto.SaveChanges();
                    MessageBox.Show($"Puerto {objPuerto.Id} eliminado correctamente (estado cambiado a 'I').");

                    // Actualizar la lista en la grilla
                    grdPuertos.DataSource = Utiles.contexto.Puertos.ToList();
                }
            }
            else
            {
                MessageBox.Show($"El puerto con ID {idPuerto} no existe.");
            }
        }
    }
}
