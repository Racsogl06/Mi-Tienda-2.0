namespace POSApp
{
    partial class Ventas
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
            txtBuscarProducto = new TextBox();
            lblBuscarProducto = new Label();
            dgvProductos = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio_Unitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            dgvCarrito = new DataGridView();
            ProductoCarrito = new DataGridViewTextBoxColumn();
            CantidadCarrito = new DataGridViewTextBoxColumn();
            Precio_UnitarioCarrito = new DataGridViewTextBoxColumn();
            SubtotalCarrito = new DataGridViewTextBoxColumn();
            btnAgregarCarrito = new Button();
            btnQuitarCarrito = new Button();
            btnFinalizarVenta = new Button();
            lblTotal = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(12, 80);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(125, 27);
            txtBuscarProducto.TabIndex = 0;
            // 
            // lblBuscarProducto
            // 
            lblBuscarProducto.AutoSize = true;
            lblBuscarProducto.Location = new Point(12, 45);
            lblBuscarProducto.Name = "lblBuscarProducto";
            lblBuscarProducto.Size = new Size(116, 20);
            lblBuscarProducto.TabIndex = 1;
            lblBuscarProducto.Text = "Buscar Producto";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Producto, Cantidad, Precio_Unitario, Subtotal });
            dgvProductos.Location = new Point(12, 113);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(553, 554);
            dgvProductos.TabIndex = 2;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 125;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 125;
            // 
            // Precio_Unitario
            // 
            Precio_Unitario.HeaderText = "Precio Unitario";
            Precio_Unitario.MinimumWidth = 6;
            Precio_Unitario.Name = "Precio_Unitario";
            Precio_Unitario.Width = 125;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 125;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { ProductoCarrito, CantidadCarrito, Precio_UnitarioCarrito, SubtotalCarrito });
            dgvCarrito.Location = new Point(585, 113);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(507, 447);
            dgvCarrito.TabIndex = 3;
            // 
            // ProductoCarrito
            // 
            ProductoCarrito.HeaderText = "Producto ";
            ProductoCarrito.MinimumWidth = 6;
            ProductoCarrito.Name = "ProductoCarrito";
            ProductoCarrito.ReadOnly = true;
            // 
            // CantidadCarrito
            // 
            CantidadCarrito.HeaderText = "Cantidad ";
            CantidadCarrito.MinimumWidth = 6;
            CantidadCarrito.Name = "CantidadCarrito";
            CantidadCarrito.ReadOnly = true;
            // 
            // Precio_UnitarioCarrito
            // 
            Precio_UnitarioCarrito.HeaderText = "Precio Unitario";
            Precio_UnitarioCarrito.MinimumWidth = 6;
            Precio_UnitarioCarrito.Name = "Precio_UnitarioCarrito";
            Precio_UnitarioCarrito.ReadOnly = true;
            // 
            // SubtotalCarrito
            // 
            SubtotalCarrito.HeaderText = "Subtotal";
            SubtotalCarrito.MinimumWidth = 6;
            SubtotalCarrito.Name = "SubtotalCarrito";
            SubtotalCarrito.ReadOnly = true;
            // 
            // btnAgregarCarrito
            // 
            btnAgregarCarrito.Location = new Point(955, 566);
            btnAgregarCarrito.Name = "btnAgregarCarrito";
            btnAgregarCarrito.Size = new Size(137, 29);
            btnAgregarCarrito.TabIndex = 5;
            btnAgregarCarrito.Text = "Agregar al Carrito";
            btnAgregarCarrito.UseVisualStyleBackColor = true;
            btnAgregarCarrito.Click += btnAgregarCarrito_Click;
            // 
            // btnQuitarCarrito
            // 
            btnQuitarCarrito.Location = new Point(955, 601);
            btnQuitarCarrito.Name = "btnQuitarCarrito";
            btnQuitarCarrito.Size = new Size(137, 29);
            btnQuitarCarrito.TabIndex = 6;
            btnQuitarCarrito.Text = "Quitar del Carrito";
            btnQuitarCarrito.UseVisualStyleBackColor = true;
            btnQuitarCarrito.Click += btnQuitarCarrito_Click;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Location = new Point(955, 636);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(137, 29);
            btnFinalizarVenta.TabIndex = 7;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = true;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(662, 636);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 20);
            lblTotal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(662, 605);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 8;
            label1.Text = "Monto Total:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(169, 79);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 694);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(btnFinalizarVenta);
            Controls.Add(btnQuitarCarrito);
            Controls.Add(btnAgregarCarrito);
            Controls.Add(lblTotal);
            Controls.Add(dgvCarrito);
            Controls.Add(dgvProductos);
            Controls.Add(lblBuscarProducto);
            Controls.Add(txtBuscarProducto);
            Name = "Ventas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProducto;
        private Label lblBuscarProducto;
        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private Button btnAgregarCarrito;
        private Button btnQuitarCarrito;
        private Button btnFinalizarVenta;
        private Label lblTotal;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio_Unitario;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn ProductoCarrito;
        private DataGridViewTextBoxColumn CantidadCarrito;
        private DataGridViewTextBoxColumn Precio_UnitarioCarrito;
        private DataGridViewTextBoxColumn SubtotalCarrito;
        private Label label1;
        private Button btnBuscar;
    }
}
