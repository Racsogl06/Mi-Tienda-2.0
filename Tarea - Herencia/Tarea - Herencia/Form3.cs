using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea___Herencia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            Miembro miembroSeleccionado = (Miembro)cmbMiembro.SelectedItem;  
            Libro libroSeleccionado = (Libro)cmbLibro.SelectedItem;  
            DateTime fechaPrestamo = dtpFechaPrestamo.Value;
            DateTime fechaDevolucion = dtpFechaDevolucion.Value;

            Prestamo nuevoPrestamo = new Prestamo(libroSeleccionado, miembroSeleccionado, fechaPrestamo, fechaDevolucion);
            miembroSeleccionado.AgregarPrestamo(nuevoPrestamo);  

            
        }

    }
}
