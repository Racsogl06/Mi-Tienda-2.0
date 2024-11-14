using System.Diagnostics;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int resultado = Factorial(1000);
            stopwatch.Stop();
            int resultadoConFor = FactorialConFor(8);
            Console.WriteLine($"Resultado {resultado}");
            Console.WriteLine$"Tiempo solucion recursiva:{stopwatch.Equals E}"
        }
        static int Factorial(int numero)
        {
            if (numero == 0)
                return 1;

            return numero * Factorial(numero - 1);

        }
        static int FactorialConFor(int numero)
        {
            int resultado = 1;
            for (int i = 1; <= numero; i++)
                resultado = resultado * i;
            return resultado;
        }
    }
}
