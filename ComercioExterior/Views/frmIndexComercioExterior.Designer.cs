namespace ComercioExterior.Views
{
    partial class frmIndexComercioExterior
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
            btnAdmPuertos = new Button();
            btnAdmUsuarios = new Button();
            label1 = new Label();
            label2 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAdmPuertos
            // 
            btnAdmPuertos.Font = new Font("Segoe UI", 10F);
            btnAdmPuertos.Location = new Point(88, 125);
            btnAdmPuertos.Name = "btnAdmPuertos";
            btnAdmPuertos.Size = new Size(190, 54);
            btnAdmPuertos.TabIndex = 0;
            btnAdmPuertos.Text = "ADMINISTRACION DE PUERTOS";
            btnAdmPuertos.UseVisualStyleBackColor = true;
            btnAdmPuertos.Click += btnAdmPuertos_Click;
            // 
            // btnAdmUsuarios
            // 
            btnAdmUsuarios.Font = new Font("Segoe UI", 10F);
            btnAdmUsuarios.Location = new Point(88, 185);
            btnAdmUsuarios.Name = "btnAdmUsuarios";
            btnAdmUsuarios.Size = new Size(190, 54);
            btnAdmUsuarios.TabIndex = 1;
            btnAdmUsuarios.Text = "ADMINISTRACION DE USUARIOS";
            btnAdmUsuarios.UseVisualStyleBackColor = true;
            btnAdmUsuarios.Click += btnAdmUsuarios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(98, 48);
            label1.Name = "label1";
            label1.Size = new Size(163, 30);
            label1.TabIndex = 2;
            label1.Text = "Pagina de inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(129, 78);
            label2.Name = "label2";
            label2.Size = new Size(102, 19);
            label2.TabIndex = 3;
            label2.Text = "Que sea hacer?";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.Location = new Point(115, 245);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 42);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmIndexComercioExterior
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 342);
            Controls.Add(btnSalir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdmUsuarios);
            Controls.Add(btnAdmPuertos);
            Name = "frmIndexComercioExterior";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagina de inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmPuertos;
        private Button btnAdmUsuarios;
        private Label label1;
        private Label label2;
        private Button btnSalir;
    }
}