﻿namespace ComercioExterior.Views
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnSalir = new Button();
            btnEliminar = new Button();
            modificar = new Button();
            btnNuevo = new Button();
            grdUsuarios = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(800, 90);
            panel1.TabIndex = 3;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(659, 36);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(129, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(524, 36);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 42);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // modificar
            // 
            modificar.Location = new Point(389, 36);
            modificar.Name = "modificar";
            modificar.Size = new Size(129, 42);
            modificar.TabIndex = 1;
            modificar.Text = "Modificar";
            modificar.UseVisualStyleBackColor = true;
            modificar.Click += modificar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(254, 36);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(129, 42);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // grdUsuarios
            // 
            grdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsuarios.Dock = DockStyle.Top;
            grdUsuarios.Location = new Point(0, 0);
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.Size = new Size(800, 295);
            grdUsuarios.TabIndex = 2;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 383);
            Controls.Add(panel1);
            Controls.Add(grdUsuarios);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            Load += frmUsuarios_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSalir;
        private Button btnEliminar;
        private Button modificar;
        private Button btnNuevo;
        private DataGridView grdPuertos;
        private DataGridView grdUsuarios;
    }
}