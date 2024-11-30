using ComercioExterior.Context;
using ComercioExterior.Models;
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
    public partial class frmMantenimientoUsuarios : Form
    {
        public int idUsuario = 0;
        public frmMantenimientoUsuarios()
        {
            InitializeComponent();
            Utiles.contexto = new Eff2Context();
        }

        private void frmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            if (idUsuario != 0)
            {
                var objCliente = Utiles.contexto.Clientes.Find(idUsuario);
                if (objCliente != null)
                {
                    txtId.Text += objCliente.Id.ToString();
                    txtCedula.Text = objCliente.Cedula;
                    txtNombre.Text = objCliente.Nombres;
                    txtApellido.Text = objCliente.Apellidos;
                }
                else
                {
                    MessageBox.Show($"No existe el registro {idUsuario}");
                    this.Close();
                }
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (idUsuario == 0)
            {
                Cliente objCliente = new Cliente();
                objCliente.Cedula = txtCedula.Text;
                objCliente.Nombres = txtNombre.Text;
                objCliente.Apellidos = txtApellido.Text;
                objCliente.Estado = "A";

                Utiles.contexto.Clientes.Add(objCliente);
                Utiles.contexto.SaveChanges();
                txtId.Text = objCliente.Id.ToString();
                MessageBox.Show($"Cliente {objCliente.Id}. Agregado con existo!.");
                this.Close();
            }
            else
            {
                var objCliente = Utiles.contexto.Clientes.Find(idUsuario);
                objCliente.Cedula = txtCedula.Text;
                objCliente.Nombres = txtNombre.Text;
                objCliente.Apellidos = txtApellido.Text;
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Cliente {objCliente.Id}. Actualizado con existo!.");
            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
