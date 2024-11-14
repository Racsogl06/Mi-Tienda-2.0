using System;

class Nodo
{
    public string Dato;
    public Nodo Siguiente;

    public Nodo(string dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnlazada
{
    private Nodo cabeza;

    public void Agregar(string dato)
    {
        Nodo nuevoNodo = new Nodo(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
        Console.WriteLine("Elemento agregado.");
    }

    public void Eliminar(string dato)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        if (cabeza.Dato == dato)
        {
            cabeza = cabeza.Siguiente;
            Console.WriteLine("Elemento eliminado.");
            return;
        }

        Nodo actual = cabeza;
        while (actual.Siguiente != null && actual.Siguiente.Dato != dato)
        {
            actual = actual.Siguiente;
        }

        if (actual.Siguiente != null)
        {
            actual.Siguiente = actual.Siguiente.Siguiente;
            Console.WriteLine("Elemento eliminado.");
        }
        else
        {
            Console.WriteLine("Elemento no encontrado.");
        }
    }

    public void Buscar(string dato)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == dato)
            {
                Console.WriteLine("Elemento encontrado en la lista.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Elemento no encontrado.");
    }

    public void Modificar(string datoViejo, string datoNuevo)
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == datoViejo)
            {
                actual.Dato = datoNuevo;
                Console.WriteLine("Elemento modificado.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Elemento no encontrado.");
    }

    public void Imprimir()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        Nodo actual = cabeza;
        Console.WriteLine("Elementos en la lista:");
        while (actual != null)
        {
            Console.WriteLine("- " + actual.Dato);
            actual = actual.Siguiente;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();
        int opcion;

        do
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Agregar un elemento");
            Console.WriteLine("2. Eliminar un elemento");
            Console.WriteLine("3. Buscar un elemento");
            Console.WriteLine("4. Modificar un elemento");
            Console.WriteLine("5. Imprimir la lista");
            Console.WriteLine("6. Salir");
            Console.Write("Selecciona una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Introduce el elemento a agregar: ");
                    string agregarDato = Console.ReadLine();
                    lista.Agregar(agregarDato);
                    break;
                case 2:
                    Console.Write("Introduce el elemento a eliminar: ");
                    string eliminarDato = Console.ReadLine();
                    lista.Eliminar(eliminarDato);
                    break;
                case 3:
                    Console.Write("Introduce el elemento a buscar: ");
                    string buscarDato = Console.ReadLine();
                    lista.Buscar(buscarDato);
                    break;
                case 4:
                    Console.Write("Introduce el elemento a modificar: ");
                    string datoViejo = Console.ReadLine();
                    Console.Write("Introduce el nuevo valor: ");
                    string datoNuevo = Console.ReadLine();
                    lista.Modificar(datoViejo, datoNuevo);
                    break;
                case 5:
                    lista.Imprimir();
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }
        } while (opcion != 6);
    }
}
