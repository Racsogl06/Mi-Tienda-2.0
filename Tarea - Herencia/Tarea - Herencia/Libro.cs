using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Herencia
{
    public abstract class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacion { get; set; }

        protected Libro(string titulo, string autor, int anoPublicacion)
        {
            Titulo = titulo;
            Autor = autor;
            AnoPublicacion = anoPublicacion;
        }

        public abstract string ObtenerDetalles();
    }


}