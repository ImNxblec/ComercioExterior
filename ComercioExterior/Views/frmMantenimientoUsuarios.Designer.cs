namespace ComercioExterior.Views
{
    partial class frmMantenimientoUsuarios
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            txtId = new TextBox();
            txtCedula = new TextBox();
            btnSalir = new Button();
            btnGrabar = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label4 = new Label();
            txtApellido = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 96);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "CEDULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 125);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "NOMBRE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 67);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(153, 117);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(273, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(153, 59);
            txtId.Name = "txtId";
            txtId.Size = new Size(273, 23);
            txtId.TabIndex = 1;
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(153, 88);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(273, 23);
            txtCedula.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(346, 25);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(105, 40);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(235, 25);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 40);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnGrabar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 100);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtCedula);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 263);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 154);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 6;
            label4.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(153, 146);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(273, 23);
            txtApellido.TabIndex = 5;
            // 
            // frmMantenimientoUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 354);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmMantenimientoUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMantenimientoUsuarios";
            Load += frmMantenimientoUsuarios_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtId;
        private TextBox txtCedula;
        private Button btnSalir;
        private Button btnGrabar;
        private Panel panel2;
        private Panel panel1;
        private Label label4;
        private TextBox txtApellido;
    }
}