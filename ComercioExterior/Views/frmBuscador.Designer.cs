namespace ComercioExterior.Views
{
    partial class frmBuscador
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
            txtFiltro = new TextBox();
            panel2 = new Panel();
            btnSalir = new Button();
            btnSeleccionar = new Button();
            panel3 = new Panel();
            grdDatos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdDatos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFiltro);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(749, 23);
            panel1.TabIndex = 0;
            // 
            // txtFiltro
            // 
            txtFiltro.Dock = DockStyle.Fill;
            txtFiltro.Location = new Point(0, 0);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(749, 23);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnSeleccionar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 227);
            panel2.Name = "panel2";
            panel2.Size = new Size(749, 49);
            panel2.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(662, 14);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(581, 14);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(75, 23);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(grdDatos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 204);
            panel3.TabIndex = 2;
            // 
            // grdDatos
            // 
            grdDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDatos.Dock = DockStyle.Fill;
            grdDatos.Location = new Point(0, 0);
            grdDatos.Name = "grdDatos";
            grdDatos.Size = new Size(749, 204);
            grdDatos.TabIndex = 0;
            grdDatos.CellContentClick += grdDatos_CellContentClick;
            grdDatos.CellDoubleClick += grdDatos_CellDoubleClick;
            // 
            // frmBuscador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 276);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmBuscador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscador";
            Load += Buscador_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grdDatos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtFiltro;
        private Panel panel2;
        private Button btnSalir;
        private Button btnSeleccionar;
        private Panel panel3;
        private DataGridView dataGridView1;
        private DataGridView grdDatos;
    }
}