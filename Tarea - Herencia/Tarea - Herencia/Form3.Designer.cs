namespace Tarea___Herencia
{
    partial class Form3
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
            cmbMiembro = new ComboBox();
            cmbLibro = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            dtpFechaDevolucion = new DateTimePicker();
            dgvPrestamos = new DataGridView();
            btnRealizarPrestamo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // cmbMiembro
            // 
            cmbMiembro.FormattingEnabled = true;
            cmbMiembro.Location = new Point(60, 89);
            cmbMiembro.Name = "cmbMiembro";
            cmbMiembro.Size = new Size(151, 28);
            cmbMiembro.TabIndex = 0;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(237, 89);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(151, 28);
            cmbLibro.TabIndex = 1;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(482, 90);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(250, 27);
            dtpFechaPrestamo.TabIndex = 2;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(482, 191);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(250, 27);
            dtpFechaDevolucion.TabIndex = 3;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(60, 162);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(389, 225);
            dgvPrestamos.TabIndex = 4;
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Location = new Point(594, 341);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(138, 29);
            btnRealizarPrestamo.TabIndex = 5;
            btnRealizarPrestamo.Text = "Realizar Prestamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRealizarPrestamo);
            Controls.Add(dgvPrestamos);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cmbLibro);
            Controls.Add(cmbMiembro);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMiembro;
        private ComboBox cmbLibro;
        private DateTimePicker dtpFechaPrestamo;
        private DateTimePicker dtpFechaDevolucion;
        private DataGridView dgvPrestamos;
        private Button btnRealizarPrestamo;
    }
}