using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Herencia
{
    public class Miembro
    {
        public string Nombre { get; set; }
        public int NumeroMiembro { get; set; }
        public List<Prestamo> HistorialPrestamos { get; set; } = new List<Prestamo>();

        public Miembro(string nombre, int numeroMiembro)
        {
            Nombre = nombre;
            NumeroMiembro = numeroMiembro;
        }

        public void AgregarPrestamo(Prestamo prestamo)
        {
            HistorialPrestamos.Add(prestamo);
        }
    }


}
