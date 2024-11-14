namespace MiTienda
{
    partial class Employee_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_management));
            dgvEmpleados = new DataGridView();
            dtpMes = new DateTimePicker();
            cmbSucursal = new ComboBox();
            btnBuscar = new Button();
            btnRegresar = new Button();
            txtNombre = new TextBox();
            txtIdEmpleado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblResumen = new Label();
            Fecha = new DataGridViewTextBoxColumn();
            Sucursal = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ID_Empleado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Fecha, Sucursal, Nombre, ID_Empleado });
            dgvEmpleados.Location = new Point(440, 43);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(553, 610);
            dgvEmpleados.TabIndex = 0;
            // 
            // dtpMes
            // 
            dtpMes.Location = new Point(172, 52);
            dtpMes.Name = "dtpMes";
            dtpMes.Size = new Size(250, 27);
            dtpMes.TabIndex = 1;
            // 
            // cmbSucursal
            // 
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(172, 99);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(250, 28);
            cmbSucursal.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(719, 670);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 37);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(852, 670);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(112, 37);
            btnRegresar.TabIndex = 4;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(192, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(208, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(192, 218);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(208, 27);
            txtIdEmpleado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 170);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 7;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 218);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 8;
            label2.Text = "ID Empleado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 54);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 103);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 10;
            label4.Text = "Sucursal:";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(286, 594);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(0, 20);
            lblResumen.TabIndex = 11;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Sucursal
            // 
            Sucursal.HeaderText = "Sucursal";
            Sucursal.MinimumWidth = 6;
            Sucursal.Name = "Sucursal";
            Sucursal.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // ID_Empleado
            // 
            ID_Empleado.HeaderText = "ID Empleado";
            ID_Empleado.MinimumWidth = 6;
            ID_Empleado.Name = "ID_Empleado";
            ID_Empleado.Width = 125;
            // 
            // Employee_management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 790);
            Controls.Add(lblResumen);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIdEmpleado);
            Controls.Add(txtNombre);
            Controls.Add(btnRegresar);
            Controls.Add(btnBuscar);
            Controls.Add(cmbSucursal);
            Controls.Add(dtpMes);
            Controls.Add(dgvEmpleados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Employee_management";
            Text = "Employee management";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private DateTimePicker dtpMes;
        private ComboBox cmbSucursal;
        private Button btnBuscar;
        private Button btnRegresar;
        private TextBox txtNombre;
        private TextBox txtIdEmpleado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblResumen;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Sucursal;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID_Empleado;
    }
}