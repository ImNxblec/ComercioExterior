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
    public partial class frmTransaccion : Form
    {
        public int IdTransaccion = 0;
        public frmTransaccion()
        {
            InitializeComponent();
            Eff2Context contexto = new Eff2Context();
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmBuscador frm = new frmBuscador();
                frm.tipo = "C";
                frm.filtro = txtCliente.Text;
                frm.ShowDialog();
                txtCliente.Text = frm.repuesta1;
                txtNombresClientes.Text = frm.repuesta2;
            }
        }

        private void txtPuerto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmBuscador frm = new frmBuscador();
                frm.tipo = "P";
                frm.filtro = txtPuerto.Text;
                frm.ShowDialog();
                txtPuerto.Text = frm.repuesta1;
                txtDescripcionPuerto.Text = frm.repuesta2;
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmTransaccion_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (IdTransaccion == 0)
            {
                Transaccion objTransaccion = new Transaccion();
                objTransaccion.TipoTransaccion = txtTipoTransaccion.Text;
                objTransaccion.IdCliente = int.Parse(txtCliente.Text);
                objTransaccion.IdPuerto = int.Parse(txtPuerto.Text);
                objTransaccion.Costo = int.Parse(txtCosto.Text);
                objTransaccion.Comentarios = txtDescripcion.Text;
                objTransaccion.Estado = "A";

                Utiles.contexto.Transaccions.Add(objTransaccion);
                Utiles.contexto.SaveChanges();
                txtId.Text = objTransaccion.Id.ToString();
                MessageBox.Show($"Transaccion {objTransaccion.Id}. Agregado con existo!.");
                this.Close();
            }
            else
            {
                var objTransaccion = Utiles.contexto.Transaccions.Find(IdTransaccion);
                objTransaccion.TipoTransaccion = txtTipoTransaccion.Text;
                objTransaccion.IdCliente = int.Parse(txtCliente.Text);
                objTransaccion.IdPuerto = int.Parse(txtPuerto.Text);
                objTransaccion.Costo = int.Parse(txtCosto.Text);
                objTransaccion.Comentarios = txtDescripcion.Text;
                objTransaccion.Estado = "A";
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Cliente {objTransaccion.Id}. Actualizado con existo!.");
            }
            this.Close();
        }
    }
}
