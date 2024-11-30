namespace ComercioExterior
{
    partial class frmPuertos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdPuertos = new DataGridView();
            panel1 = new Panel();
            btnSalir = new Button();
            btnEliminar = new Button();
            modificar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)grdPuertos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grdPuertos
            // 
            grdPuertos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPuertos.Dock = DockStyle.Top;
            grdPuertos.Location = new Point(0, 0);
            grdPuertos.Name = "grdPuertos";
            grdPuertos.Size = new Size(896, 295);
            grdPuertos.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(modificar);
            panel1.Controls.Add(btnNuevo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 293);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 90);
            panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(742, 27);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(607, 27);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 42);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // modificar
            // 
            modificar.Location = new Point(472, 27);
            modificar.Name = "modificar";
            modificar.Size = new Size(129, 42);
            modificar.TabIndex = 1;
            modificar.Text = "Modificar";
            modificar.UseVisualStyleBackColor = true;
            modificar.Click += btnModificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(337, 27);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(129, 42);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmPuertos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 383);
            Controls.Add(panel1);
            Controls.Add(grdPuertos);
            Name = "frmPuertos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administracion de puertos";
            Load += frmPuertos_Load;
            ((System.ComponentModel.ISupportInitialize)grdPuertos).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdPuertos;
        private Panel panel1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button modificar;
        private Button btnNuevo;
    }
}
