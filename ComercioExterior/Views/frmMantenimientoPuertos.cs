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

namespace ComercioExterior
{
    public partial class frmMantenimientoPuertos : Form
    {

        public int idPuerto = 0;
        public frmMantenimientoPuertos()
        {
            InitializeComponent();
            Utiles.contexto = new Eff2Context();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (idPuerto == 0)
            {
                Puerto objPuerto = new Puerto();
                objPuerto.Descripcion = txtDescripcion.Text;
                objPuerto.Codigo = txtPuerto.Text;
                objPuerto.Estado = "A";

                Utiles.contexto.Puertos.Add(objPuerto);
                Utiles.contexto.SaveChanges();
                txtId.Text = objPuerto.Id.ToString();
                MessageBox.Show($"Puerto {objPuerto.Id} creado con existo!.");
                this.Close();
            } else
            {
                var objPuerto = Utiles.contexto.Puertos.Find(idPuerto);
                objPuerto.Codigo = txtPuerto.Text;
                objPuerto.Descripcion = txtDescripcion.Text;
                Utiles.contexto.SaveChanges();
                MessageBox.Show($"Puerto {objPuerto.Id} actualizado con exito!");
            }
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenimientoPuertos_Load(object sender, EventArgs e)
        {
            if (idPuerto != 0) {
                var objPuerto = Utiles.contexto.Puertos.Find(idPuerto);
                if (objPuerto != null) { 
                    txtId.Text += objPuerto.Id.ToString();
                    txtPuerto.Text = objPuerto.Codigo;
                    txtDescripcion.Text = objPuerto.Descripcion;
                } else {
                    MessageBox.Show($"No existe el registro {idPuerto}");
                    this.Close();
                }
            }
        }
    }
}
