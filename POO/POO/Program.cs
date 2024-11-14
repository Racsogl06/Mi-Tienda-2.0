namespace POO
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime cual es tu edad?");
            int edad = Convert.ToInt32(Console.ReadLine());

            Perro firulais = new Perro();

            firulais.saludar();

            Console.WriteLine(firulais.nombre);

            Perro max = new Perro("Max");
            Console.WriteLine(max.nombre);
        }
    }
 

    
}
