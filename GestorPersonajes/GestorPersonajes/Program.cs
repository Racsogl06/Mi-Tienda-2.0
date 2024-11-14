using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Guerrero guerrero = new Guerrero { Nombre = "Aragorn", Nivel = 1, PuntosVida = 100, Fuerza = 20 };
        Mago mago = new Mago { Nombre = "Gandalf", Nivel = 1, PuntosVida = 80, Mana = 50 };
        Arquero arquero = new Arquero { Nombre = "Legolas", Nivel = 1, PuntosVida = 90, Precision = 15 };

        List<Personaje> personajes = new List<Personaje> { guerrero, mago, arquero };

        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Sistema de Gestión de Personajes");
            Console.WriteLine("1. Ver información de los personajes");
            Console.WriteLine("2. Atacar con un personaje");
            Console.WriteLine("3. Subir de nivel a un personaje");
            Console.WriteLine("4. Salir");
            Console.Write("Selecciona una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    foreach (Personaje personaje in personajes)
                    {
                        Console.WriteLine(personaje.MostrarInformacion());
                    }
                    break;

                case "2":
                    Console.WriteLine("Selecciona un personaje para atacar:");
                    for (int i = 0; i < personajes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {personajes[i].Nombre}");
                    }
                    int eleccionAtacar;
                    if (int.TryParse(Console.ReadLine(), out eleccionAtacar) && eleccionAtacar >= 1 && eleccionAtacar <= personajes.Count)
                    {
                        Console.WriteLine(personajes[eleccionAtacar - 1].Atacar());
                    }
                    else
                    {
                        Console.WriteLine("Selección inválida.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Selecciona un personaje para subir de nivel:");
                    for (int i = 0; i < personajes.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {personajes[i].Nombre}");
                    }
                    int eleccionSubirNivel;
                    if (int.TryParse(Console.ReadLine(), out eleccionSubirNivel) && eleccionSubirNivel >= 1 && eleccionSubirNivel <= personajes.Count)
                    {
                        personajes[eleccionSubirNivel - 1].SubirNivel();
                        Console.WriteLine("Nivel subido con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Selección inválida.");
                    }
                    break;

                case "4":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
