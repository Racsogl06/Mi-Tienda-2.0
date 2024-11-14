using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Animal
    {
        protected int cantidadPatas;
        public string nombre;

        public void saludar()
        {
            Console.WriteLine("Hola soy un animal");
        }
    }
}
