namespace BibliotecaHerecia
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            btnAdminMiembros = new PictureBox();
            btnAdminLibros = new PictureBox();
            btnRealizarPrestamo = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)btnAdminMiembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRealizarPrestamo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 49);
            label1.Name = "label1";
            label1.Size = new Size(333, 25);
            label1.TabIndex = 7;
            label1.Text = "Seleccione una opción para comenzar";
            // 
            // btnAdminMiembros
            // 
            btnAdminMiembros.Image = Properties.Resources.miembros;
            btnAdminMiembros.InitialImage = Properties.Resources.miembros;
            btnAdminMiembros.Location = new Point(94, 139);
            btnAdminMiembros.Name = "btnAdminMiembros";
            btnAdminMiembros.Size = new Size(140, 146);
            btnAdminMiembros.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAdminMiembros.TabIndex = 8;
            btnAdminMiembros.TabStop = false;
            btnAdminMiembros.Click += btnAdminMiembros_Click;
            // 
            // btnAdminLibros
            // 
            btnAdminLibros.Image = Properties.Resources.libros;
            btnAdminLibros.InitialImage = Properties.Resources.libros;
            btnAdminLibros.Location = new Point(330, 139);
            btnAdminLibros.Name = "btnAdminLibros";
            btnAdminLibros.Size = new Size(140, 146);
            btnAdminLibros.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAdminLibros.TabIndex = 9;
            btnAdminLibros.TabStop = false;
            btnAdminLibros.Click += btnAdminLibros_Click;
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Image = Properties.Resources.prestamo;
            btnRealizarPrestamo.InitialImage = Properties.Resources.prestamo;
            btnRealizarPrestamo.Location = new Point(571, 139);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(140, 146);
            btnRealizarPrestamo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnRealizarPrestamo.TabIndex = 10;
            btnRealizarPrestamo.TabStop = false;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // label2
            // 
            label2.Location = new Point(94, 301);
            label2.Name = "label2";
            label2.Size = new Size(140, 45);
            label2.TabIndex = 11;
            label2.Text = "Administración de Miembros";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(330, 301);
            label3.Name = "label3";
            label3.Size = new Size(140, 45);
            label3.TabIndex = 12;
            label3.Text = "Administración de Libros";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(583, 311);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 13;
            label4.Text = "Realizar Préstamo";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRealizarPrestamo);
            Controls.Add(btnAdminLibros);
            Controls.Add(btnAdminMiembros);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)btnAdminMiembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdminLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRealizarPrestamo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox btnAdminMiembros;
        private PictureBox btnAdminLibros;
        private PictureBox btnRealizarPrestamo;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}