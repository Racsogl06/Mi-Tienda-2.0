using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tarea___Herencia
{
    public partial class Form1 : Form
    {

        private List<Libro> libros = new List<Libro>();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            int anoPublicacion = (int)nudAnoPublicacion.Value;

            if (cmbTipoLibro.SelectedItem.ToString() == "Fisico")
            {
                string ubicacion = txtUbicacion.Text;
                LibroFisico libroFisico = new LibroFisico(titulo, autor, anoPublicacion, ubicacion);
                libros.Add(libroFisico); 
            }
            else if (cmbTipoLibro.SelectedItem.ToString() == "Electronico")
            {
                double tamanoArchivo = double.Parse(txtTamanoArchivo.Text);
                string formato = txtFormato.Text;
                LibroElectronico libroElectronico = new LibroElectronico(titulo, autor, anoPublicacion, tamanoArchivo, formato);
                libros.Add(libroElectronico); 
            }

            ActualizarDataGridView();
        }

        private void btnModificarLibro_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
        }

        private void ActualizarDataGridView()
        {
            dgvLibros.Rows.Clear();
            foreach (var libro in libros)
            {
                dgvLibros.Rows.Add(libro.Titulo, libro.Autor, libro.AnoPublicacion);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoLibro.Items.Add("Fisico");
            cmbTipoLibro.Items.Add("Electronico");
            cmbTipoLibro.SelectedIndex = 0; 
        }

        private void cmbTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoLibro.SelectedItem.ToString() == "Fisico")
            {
                txtUbicacion.Visible = true;
                txtTamanoArchivo.Visible = false;
                txtFormato.Visible = false;
            }
            else if (cmbTipoLibro.SelectedItem.ToString() == "Electronico")
            {
                txtUbicacion.Visible = false;
                txtTamanoArchivo.Visible = true;
                txtFormato.Visible = true;
            }
        }
    }
}
