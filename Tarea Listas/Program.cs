using System;

class NodoDoble
{
    public string Dato;
    public NodoDoble Anterior;
    public NodoDoble Siguiente;

    public NodoDoble(string dato)
    {
        Dato = dato;
        Anterior = null;
        Siguiente = null;
    }
}

class ListaDoble
{
    private NodoDoble cabeza;

    public void Agregar(string dato)
    {
        NodoDoble nuevoNodo = new NodoDoble(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            NodoDoble actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = actual;
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

        NodoDoble actual = cabeza;
        while (actual != null)
        {
            if (actual.Dato == dato)
            {
                if (actual.Anterior != null)
                {
                    actual.Anterior.Siguiente = actual.Siguiente;
                }
                else
                {
                    cabeza = actual.Siguiente;
                }

                if (actual.Siguiente != null)
                {
                    actual.Siguiente.Anterior = actual.Anterior;
                }

                Console.WriteLine("Elemento eliminado.");
                return;
            }
            actual = actual.Siguiente;
        }
        Console.WriteLine("Elemento no encontrado.");
    }

    public void Buscar(string dato)
    {
        NodoDoble actual = cabeza;
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
        NodoDoble actual = cabeza;
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

    public void ImprimirAdelante()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cabeza;
        Console.WriteLine("Lista de elementos (hacia adelante):");
        while (actual != null)
        {
            Console.WriteLine("- " + actual.Dato);
            actual = actual.Siguiente;
        }
    }

    public void ImprimirAtras()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoDoble actual = cabeza;
        while (actual.Siguiente != null)
        {
            actual = actual.Siguiente;
        }

        Console.WriteLine("Lista de elementos (hacia atrás):");
        while (actual != null)
        {
            Console.WriteLine("- " + actual.Dato);
            actual = actual.Anterior;
        }
    }
}

class NodoCircular
{
    public string Dato;
    public NodoCircular Siguiente;

    public NodoCircular(string dato)
    {
        Dato = dato;
        Siguiente = this;
    }
}

class ListaCircular
{
    private NodoCircular cabeza;

    public void Agregar(string dato)
    {
        NodoCircular nuevoNodo = new NodoCircular(dato);
        if (cabeza == null)
        {
            cabeza = nuevoNodo;
        }
        else
        {
            NodoCircular actual = cabeza;
            while (actual.Siguiente != cabeza)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
            nuevoNodo.Siguiente = cabeza;
        }
        Console.WriteLine("Elemento agregado a la lista circular.");
    }

    public void Eliminar(string dato)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoCircular actual = cabeza;
        NodoCircular anterior = null;

        do
        {
            if (actual.Dato == dato)
            {
                if (anterior != null)
                {
                    anterior.Siguiente = actual.Siguiente;
                }
                else
                {
                    if (actual.Siguiente == cabeza)
                    {
                        cabeza = null;
                    }
                    else
                    {
                        NodoCircular temp = cabeza;
                        while (temp.Siguiente != cabeza)
                        {
                            temp = temp.Siguiente;
                        }
                        cabeza = cabeza.Siguiente;
                        temp.Siguiente = cabeza;
                    }
                }
                Console.WriteLine("Elemento eliminado de la lista circular.");
                return;
            }
            anterior = actual;
            actual = actual.Siguiente;
        } while (actual != cabeza);

        Console.WriteLine("Elemento no encontrado.");
    }

    public void Buscar(string dato)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoCircular actual = cabeza;
        do
        {
            if (actual.Dato == dato)
            {
                Console.WriteLine("Elemento encontrado en la lista circular.");
                return;
            }
            actual = actual.Siguiente;
        } while (actual != cabeza);

        Console.WriteLine("Elemento no encontrado.");
    }

    public void Modificar(string datoViejo, string datoNuevo)
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoCircular actual = cabeza;
        do
        {
            if (actual.Dato == datoViejo)
            {
                actual.Dato = datoNuevo;
                Console.WriteLine("Elemento modificado en la lista circular.");
                return;
            }
            actual = actual.Siguiente;
        } while (actual != cabeza);

        Console.WriteLine("Elemento no encontrado.");
    }

    public void Imprimir()
    {
        if (cabeza == null)
        {
            Console.WriteLine("La lista está vacía.");
            return;
        }

        NodoCircular actual = cabeza;
        Console.WriteLine("Elementos en la lista circular:");
        do
        {
            Console.WriteLine("- " + actual.Dato);
            actual = actual.Siguiente;
        } while (actual != cabeza);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaDoble listaDoble = new ListaDoble();
        ListaCircular listaCircular = new ListaCircular();
        int opcion;

        Console.WriteLine("Integrantes del grupo:");
        Console.WriteLine("- Nombre 1");
        Console.WriteLine("- Nombre 2");
        Console.WriteLine("- Nombre 3");
        Console.WriteLine("- Nombre 4");

    }
}
