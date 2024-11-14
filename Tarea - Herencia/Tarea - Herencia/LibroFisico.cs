using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Herencia
{
    public class LibroFisico : Libro
    {
        public string Ubicacion { get; set; }

        public LibroFisico(string titulo, string autor, int anoPublicacion, string ubicacion)
            : base(titulo, autor, anoPublicacion)
        {
            Ubicacion = ubicacion;
        }

        public override string ObtenerDetalles()
        {
            return $"{Titulo} - {Autor} (Físico, {AnoPublicacion}) - Ubicación: {Ubicacion}";
        }
    }


}
