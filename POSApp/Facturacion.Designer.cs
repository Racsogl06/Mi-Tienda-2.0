namespace POSApp
{
    partial class Facturacion
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
            lblNIT = new Label();
            txtNIT = new TextBox();
            lblNombreCliente = new Label();
            txtNombreCliente = new TextBox();
            btnConfirmarVenta = new Button();
            btnCancelar = new Button();
            dgvFactura = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            lblTotalFactura = new Label();
            txtTotalFactura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            SuspendLayout();
            // 
            // lblNIT
            // 
            lblNIT.AutoSize = true;
            lblNIT.Location = new Point(43, 58);
            lblNIT.Name = "lblNIT";
            lblNIT.Size = new Size(107, 20);
            lblNIT.TabIndex = 0;
            lblNIT.Text = "NIT del Cliente";
            // 
            // txtNIT
            // 
            txtNIT.Location = new Point(43, 81);
            txtNIT.Name = "txtNIT";
            txtNIT.Size = new Size(125, 27);
            txtNIT.TabIndex = 1;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(216, 58);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(139, 20);
            lblNombreCliente.TabIndex = 2;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(216, 81);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(125, 27);
            txtNombreCliente.TabIndex = 3;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(643, 343);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(124, 29);
            btnConfirmarVenta.TabIndex = 4;
            btnConfirmarVenta.Text = "Confirmar Venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(643, 378);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 29);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactura.Columns.AddRange(new DataGridViewColumn[] { nombre, precio, cantidad, Subtotal });
            dgvFactura.Location = new Point(43, 138);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(517, 269);
            dgvFactura.TabIndex = 6;
            // 
            // nombre
            // 
            nombre.HeaderText = "Producto";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Cantidad";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Precio Unitario";
            cantidad.MinimumWidth = 6;
            cantidad.Name = "cantidad";
            cantidad.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // lblTotalFactura
            // 
            lblTotalFactura.AutoSize = true;
            lblTotalFactura.Location = new Point(435, 58);
            lblTotalFactura.Name = "lblTotalFactura";
            lblTotalFactura.Size = new Size(136, 20);
            lblTotalFactura.TabIndex = 7;
            lblTotalFactura.Text = "Total de la Compra";
            // 
            // txtTotalFactura
            // 
            txtTotalFactura.Location = new Point(435, 81);
            txtTotalFactura.Name = "txtTotalFactura";
            txtTotalFactura.Size = new Size(125, 27);
            txtTotalFactura.TabIndex = 8;
            // 
            // Facturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtTotalFactura);
            Controls.Add(lblTotalFactura);
            Controls.Add(dgvFactura);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            Controls.Add(txtNIT);
            Controls.Add(lblNIT);
            Name = "Facturacion";
            Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNIT;
        private TextBox txtNIT;
        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private Button btnConfirmarVenta;
        private Button btnCancelar;
        private DataGridView dgvFactura;
        private Label lblTotalFactura;
        private TextBox txtTotalFactura;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Subtotal;
    }
}