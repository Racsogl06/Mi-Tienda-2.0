using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea___Herencia
{
    public class LibroElectronico : Libro
    {
        public double TamanoArchivo { get; set; }
        public string Formato { get; set; }

        public LibroElectronico(string titulo, string autor, int anoPublicacion, double tamanoArchivo, string formato)
            : base(titulo, autor, anoPublicacion)
        {
            TamanoArchivo = tamanoArchivo;
            Formato = formato;
        }

        public override string ObtenerDetalles()
        {
            return $"{Titulo} - {Autor} (Electrónico, {AnoPublicacion}) - Tamaño: {TamanoArchivo}MB, Formato: {Formato}";
        }
    }


}
