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
    public partial class frmIndexComercioExterior : Form
    {
        public frmIndexComercioExterior()
        {
            InitializeComponent();
        }

        private void btnAdmPuertos_Click(object sender, EventArgs e)
        {
            frmPuertos formulario = new frmPuertos();
            formulario.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
            this.Hide();
        }
    }
}
