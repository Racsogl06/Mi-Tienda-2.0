﻿namespace ProyectoFinalPOS.Carrito
{
    partial class CarritoItemCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblPrice = new Label();
            btnEliminar = new Button();
            lblCantidad = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(3, 11);
            lblName.Name = "lblName";
            lblName.Size = new Size(113, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // lblPrice
            // 
            lblPrice.ForeColor = Color.White;
            lblPrice.Location = new Point(162, 11);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(60, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Precio";
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Image = Properties.Resources.x_mark_3_24;
            btnEliminar.Location = new Point(218, 7);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(39, 25);
            btnEliminar.TabIndex = 2;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(122, 11);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(34, 14);
            lblCantidad.TabIndex = 3;
            lblCantidad.Text = "Cantidad";
            // 
            // CarritoItemCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 42, 60);
            Controls.Add(lblCantidad);
            Controls.Add(btnEliminar);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Name = "CarritoItemCard";
            Size = new Size(260, 39);
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private Label lblPrice;
        private Button btnEliminar;
        private Label lblCantidad;
    }
}
