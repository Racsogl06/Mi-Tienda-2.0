using BibliotecaHerecia.Miembros;
using BibliotecaHerecia.Libros;
using BibliotecaHerecia.Prestamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaHerecia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAdminMiembros_Click(object sender, EventArgs e)
        {
            Form verMiembrosForm = new VerMiembros();
            verMiembrosForm.Show();
        }

        private void btnAdminLibros_Click(object sender, EventArgs e)
        {
            Form verLibrosForm = new VerLibros();
            verLibrosForm.Show();
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            Form realizarPrestamoForm = new RealizarPrestamo();
            realizarPrestamoForm.Show();
        }
    }
}
