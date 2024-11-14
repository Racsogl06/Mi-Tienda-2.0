namespace Tarea___Herencia
{
    partial class Form1
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
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            nudAnoPublicacion = new NumericUpDown();
            cmbTipoLibro = new ComboBox();
            txtUbicacion = new TextBox();
            txtTamanoArchivo = new TextBox();
            txtFormato = new TextBox();
            dgvLibros = new DataGridView();
            btnAgregarLibro = new Button();
            btnModificarLibro = new Button();
            btnEliminarLibro = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudAnoPublicacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(39, 56);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 0;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(39, 112);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(125, 27);
            txtAutor.TabIndex = 1;
            // 
            // nudAnoPublicacion
            // 
            nudAnoPublicacion.Location = new Point(39, 174);
            nudAnoPublicacion.Name = "nudAnoPublicacion";
            nudAnoPublicacion.Size = new Size(150, 27);
            nudAnoPublicacion.TabIndex = 2;
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(256, 55);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(151, 28);
            cmbTipoLibro.TabIndex = 3;
            cmbTipoLibro.SelectedIndexChanged += cmbTipoLibro_SelectedIndexChanged;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(256, 112);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(125, 27);
            txtUbicacion.TabIndex = 4;
            // 
            // txtTamanoArchivo
            // 
            txtTamanoArchivo.Location = new Point(256, 174);
            txtTamanoArchivo.Name = "txtTamanoArchivo";
            txtTamanoArchivo.Size = new Size(125, 27);
            txtTamanoArchivo.TabIndex = 5;
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(473, 56);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(125, 27);
            txtFormato.TabIndex = 6;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(39, 236);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(559, 188);
            dgvLibros.TabIndex = 7;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(625, 307);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(110, 29);
            btnAgregarLibro.TabIndex = 8;
            btnAgregarLibro.Text = "Agregar Libro";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // btnModificarLibro
            // 
            btnModificarLibro.Location = new Point(625, 352);
            btnModificarLibro.Name = "btnModificarLibro";
            btnModificarLibro.Size = new Size(128, 29);
            btnModificarLibro.TabIndex = 9;
            btnModificarLibro.Text = "Modificar Libro";
            btnModificarLibro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarLibro
            // 
            btnEliminarLibro.Location = new Point(625, 395);
            btnEliminarLibro.Name = "btnEliminarLibro";
            btnEliminarLibro.Size = new Size(109, 29);
            btnEliminarLibro.TabIndex = 10;
            btnEliminarLibro.Text = "Eliminar Libro";
            btnEliminarLibro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 11;
            label1.Text = "Titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 12;
            label2.Text = "Autor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 151);
            label3.Name = "label3";
            label3.Size = new Size(137, 20);
            label3.TabIndex = 13;
            label3.Text = "Año de Publicación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 33);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 14;
            label4.Text = "Tipo de Libro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(256, 89);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 15;
            label5.Text = "Ubicación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 151);
            label6.Name = "label6";
            label6.Size = new Size(172, 20);
            label6.TabIndex = 16;
            label6.Text = "Tamaño de Archivo (MB)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(473, 33);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 17;
            label7.Text = "Formato";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminarLibro);
            Controls.Add(btnModificarLibro);
            Controls.Add(btnAgregarLibro);
            Controls.Add(dgvLibros);
            Controls.Add(txtFormato);
            Controls.Add(txtTamanoArchivo);
            Controls.Add(txtUbicacion);
            Controls.Add(cmbTipoLibro);
            Controls.Add(nudAnoPublicacion);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudAnoPublicacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private TextBox txtAutor;
        private NumericUpDown nudAnoPublicacion;
        private ComboBox cmbTipoLibro;
        private TextBox txtUbicacion;
        private TextBox txtTamanoArchivo;
        private TextBox txtFormato;
        private DataGridView dgvLibros;
        private Button btnAgregarLibro;
        private Button btnModificarLibro;
        private Button btnEliminarLibro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
