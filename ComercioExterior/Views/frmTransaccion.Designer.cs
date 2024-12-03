namespace ComercioExterior.Views
{
    partial class frmTransaccion
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
            label1 = new Label();
            label2 = new Label();
            txtCliente = new TextBox();
            txtPuerto = new TextBox();
            txtDescripcionPuerto = new TextBox();
            txtNombresClientes = new TextBox();
            label3 = new Label();
            txtId = new TextBox();
            btnGuardar = new Button();
            btnSalir = new Button();
            txtTipoTransaccion = new TextBox();
            label4 = new Label();
            txtCosto = new TextBox();
            label5 = new Label();
            Descripcion = new Label();
            txtDescripcion = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 102);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 131);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Puerto";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(171, 94);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(100, 23);
            txtCliente.TabIndex = 2;
            txtCliente.TextChanged += txtCliente_TextChanged;
            txtCliente.KeyDown += txtCliente_KeyDown;
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(171, 123);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(100, 23);
            txtPuerto.TabIndex = 3;
            txtPuerto.KeyDown += txtPuerto_KeyDown;
            // 
            // txtDescripcionPuerto
            // 
            txtDescripcionPuerto.Location = new Point(277, 123);
            txtDescripcionPuerto.Name = "txtDescripcionPuerto";
            txtDescripcionPuerto.Size = new Size(213, 23);
            txtDescripcionPuerto.TabIndex = 4;
            // 
            // txtNombresClientes
            // 
            txtNombresClientes.Location = new Point(277, 94);
            txtNombresClientes.Name = "txtNombresClientes";
            txtNombresClientes.Size = new Size(213, 23);
            txtNombresClientes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 39);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 6;
            label3.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(171, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(320, 247);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(401, 247);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtTipoTransaccion
            // 
            txtTipoTransaccion.Location = new Point(171, 65);
            txtTipoTransaccion.Name = "txtTipoTransaccion";
            txtTipoTransaccion.Size = new Size(100, 23);
            txtTipoTransaccion.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 68);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 10;
            label4.Text = "Tipo de transsaccion";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(171, 152);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 160);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "Costo";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(96, 184);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(69, 15);
            Descripcion.TabIndex = 14;
            Descripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(171, 184);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(319, 50);
            txtDescripcion.TabIndex = 16;
            txtDescripcion.Text = "";
            // 
            // frmTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 295);
            Controls.Add(txtDescripcion);
            Controls.Add(Descripcion);
            Controls.Add(txtCosto);
            Controls.Add(label5);
            Controls.Add(txtTipoTransaccion);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(txtNombresClientes);
            Controls.Add(txtDescripcionPuerto);
            Controls.Add(txtPuerto);
            Controls.Add(txtCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTransaccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransaccion";
            Load += frmTransaccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCliente;
        private TextBox txtPuerto;
        private TextBox txtDescripcionPuerto;
        private TextBox txtNombresClientes;
        private Label label3;
        private TextBox txtId;
        private Button btnGuardar;
        private Button btnSalir;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox txtTipoTransaccion;
        private TextBox txtCosto;
        private Label label5;
        private Label label6;
        private Label Descripcion;
        private RichTextBox txtDescripcion;
    }
}