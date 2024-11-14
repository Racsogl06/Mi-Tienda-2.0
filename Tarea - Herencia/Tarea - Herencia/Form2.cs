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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnAgregarMiembro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreMiembro.Text;
            int numeroMiembro = (int)nudNumeroMiembro.Value;
            Miembro nuevoMiembro = new Miembro(nombre, numeroMiembro);

        }

        private void btnModificarMiembro_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarMiembro_Click(object sender, EventArgs e)
        {

        }

    }
}
