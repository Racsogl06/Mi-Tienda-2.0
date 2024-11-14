using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Perro : Animal
    {
        string raza;

        public Perro()
        {
            this.raza = "Desconocida";
            this.cantidadPatas = 4;
            this.nombre = "Sin nombre";
        }
        public Perro(string nombre)
        {
            this.raza = "Desconocida";
            this.cantidadPatas = 4;
            this.nombre = nombre;
        }
        public Perro(string nombre)
        {
            this.raza = "Desconocida";
            this.cantidadPatas = 4;
            this.nombre = nombre;
        }
    }
}
