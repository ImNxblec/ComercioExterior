using ComercioExterior.Context;
using Microsoft.IdentityModel.Tokens;
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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            Utiles.contexto = new Eff2Context();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            var listaUsuarios = Utiles.contexto.Clientes.ToList();
            grdUsuarios.DataSource = listaUsuarios;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmIndexComercioExterior indexForm = new frmIndexComercioExterior();
            indexForm.StartPosition = FormStartPosition.CenterScreen;
            indexForm.Show();
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoUsuarios formulario = new frmMantenimientoUsuarios();
            formulario.ShowDialog();
            var listaUsuarios = Utiles.contexto.Clientes.ToList();
            grdUsuarios.DataSource = listaUsuarios;
        }

        private void Modificar()
        {
            if (grdUsuarios.RowCount <= 0)
            {
                MessageBox.Show("No existen datos");
                return;
            }
            else
            {
                int id = Convert.ToInt32(grdUsuarios.CurrentRow.Cells[0].Value);
                frmMantenimientoUsuarios formulario = new frmMantenimientoUsuarios();
                formulario.idUsuario = id;
                formulario.ShowDialog();

            }
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (grdUsuarios.RowCount <= 0)
            {
                MessageBox.Show("No existen datos para eliminar.");
                return;
            }

            int idUsuario = Convert.ToInt32(grdUsuarios.CurrentRow.Cells[0].Value);

            var objCliente = Utiles.contexto.Clientes.Find(idUsuario);
            if (objCliente != null)
            {
                // Confirmación antes de eliminar
                var confirmResult = MessageBox.Show(
                    $"¿Estás seguro de eliminar el cliente {objCliente.Estado}?",
                    "Confirmación de eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmResult == DialogResult.Yes)
                {
                    // Cambiar estado a "I" para marcarlo como inactivo
                    objCliente.Estado = "I";
                    Utiles.contexto.SaveChanges();
                    MessageBox.Show($"Cliente {objCliente.Id} eliminado correctamente (estado cambiado a 'I').");

                    // Actualizar la lista en la grilla
                    grdUsuarios.DataSource = Utiles.contexto.Clientes.ToList();
                }
            }
            else
            {
                MessageBox.Show($"El usuario con ID {idUsuario} no existe.");
            }
        }
    }
}
