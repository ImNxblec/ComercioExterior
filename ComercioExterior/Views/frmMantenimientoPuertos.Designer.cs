namespace ComercioExterior
{
    partial class frmMantenimientoPuertos
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            txtPuerto = new TextBox();
            panel2 = new Panel();
            btnSalir = new Button();
            btnGrabar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtPuerto);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 263);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 118);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "PUERTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 182);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "DESCRIPCION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 62);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(156, 179);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(273, 23);
            txtDescripcion.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(156, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(273, 23);
            txtId.TabIndex = 1;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(156, 115);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(273, 23);
            txtPuerto.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnGrabar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(536, 100);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(397, 36);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 40);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(286, 36);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 40);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // frmMantenimientoPuertos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 359);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMantenimientoPuertos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de puertos";
            Load += frmMantenimientoPuertos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSalir;
        private Button btnGrabar;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtId;
        private TextBox txtPuerto;
    }
}