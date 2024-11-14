using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Herencia
{
    public class Prestamo
    {
        public Libro LibroPrestado { get; set; }
        public Miembro Miembro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public Prestamo(Libro libroPrestado, Miembro miembro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            LibroPrestado = libroPrestado;
            Miembro = miembro;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = fechaDevolucion;
        }
    }

}
