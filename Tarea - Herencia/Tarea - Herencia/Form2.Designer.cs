namespace Tarea___Herencia
{
    partial class Form2
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
            txtNombreMiembro = new TextBox();
            nudNumeroMiembro = new NumericUpDown();
            dgvMiembros = new DataGridView();
            btnAgregarMiembro = new Button();
            btnModificarMiembro = new Button();
            btnEliminarMiembro = new Button();
            ((System.ComponentModel.ISupportInitialize)nudNumeroMiembro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).BeginInit();
            SuspendLayout();
            // 
            // txtNombreMiembro
            // 
            txtNombreMiembro.Location = new Point(46, 77);
            txtNombreMiembro.Name = "txtNombreMiembro";
            txtNombreMiembro.Size = new Size(125, 27);
            txtNombreMiembro.TabIndex = 0;
            // 
            // nudNumeroMiembro
            // 
            nudNumeroMiembro.Location = new Point(304, 77);
            nudNumeroMiembro.Name = "nudNumeroMiembro";
            nudNumeroMiembro.Size = new Size(150, 27);
            nudNumeroMiembro.TabIndex = 1;
            // 
            // dgvMiembros
            // 
            dgvMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiembros.Location = new Point(46, 166);
            dgvMiembros.Name = "dgvMiembros";
            dgvMiembros.RowHeadersWidth = 51;
            dgvMiembros.Size = new Size(428, 255);
            dgvMiembros.TabIndex = 2;
            // 
            // btnAgregarMiembro
            // 
            btnAgregarMiembro.Location = new Point(544, 184);
            btnAgregarMiembro.Name = "btnAgregarMiembro";
            btnAgregarMiembro.Size = new Size(138, 29);
            btnAgregarMiembro.TabIndex = 3;
            btnAgregarMiembro.Text = "Agregar Miembro";
            btnAgregarMiembro.UseVisualStyleBackColor = true;
            btnAgregarMiembro.Click += btnAgregarMiembro_Click;
            // 
            // btnModificarMiembro
            // 
            btnModificarMiembro.Location = new Point(544, 233);
            btnModificarMiembro.Name = "btnModificarMiembro";
            btnModificarMiembro.Size = new Size(150, 29);
            btnModificarMiembro.TabIndex = 4;
            btnModificarMiembro.Text = "Modificar Miembro";
            btnModificarMiembro.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMiembro
            // 
            btnEliminarMiembro.Location = new Point(544, 284);
            btnEliminarMiembro.Name = "btnEliminarMiembro";
            btnEliminarMiembro.Size = new Size(141, 29);
            btnEliminarMiembro.TabIndex = 5;
            btnEliminarMiembro.Text = "Eliminar Miembro";
            btnEliminarMiembro.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminarMiembro);
            Controls.Add(btnModificarMiembro);
            Controls.Add(btnAgregarMiembro);
            Controls.Add(dgvMiembros);
            Controls.Add(nudNumeroMiembro);
            Controls.Add(txtNombreMiembro);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)nudNumeroMiembro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreMiembro;
        private NumericUpDown nudNumeroMiembro;
        private DataGridView dgvMiembros;
        private Button btnAgregarMiembro;
        private Button btnModificarMiembro;
        private Button btnEliminarMiembro;
    }
}