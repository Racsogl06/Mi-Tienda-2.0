using System;

class Program
{
    static void Main(string[] args)
    {
        var inventario = new Inventario();
        var historialTransacciones = new HistorialTransacciones();

        while (true)
        {
            Console.WriteLine("Menu Principal:");
            Console.WriteLine("1. Agregar Producto");
            Console.WriteLine("2. Eliminar Producto");
            Console.WriteLine("3. Actualizar Producto");
            Console.WriteLine("4. Realizar Compra");
            Console.WriteLine("5. Ver Historial de Transacciones");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarProducto(inventario);
                    break;
                case "2":
                    EliminarProducto(inventario);
                    break;
                case "3":
                    ActualizarProducto(inventario);
                    break;
                case "4":
                    RealizarCompra(inventario, historialTransacciones);
                    break;
                case "5":
                    VerHistorial(historialTransacciones);
                    break;
                case "6":
                    Console.WriteLine("Saliendo...");
                    return; 
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    static void AgregarProducto(Inventario inventario)
    {
        Console.Write("Ingrese el nombre del producto: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el precio del producto: ");
        decimal precio = decimal.Parse(Console.ReadLine());
        Console.Write("Ingrese la cantidad del producto: ");
        int cantidad = int.Parse(Console.ReadLine());

        var producto = new Producto(nombre, precio, cantidad);
        inventario.AgregarProducto(producto);
        Console.WriteLine("Producto agregado exitosamente.");
    }

    static void EliminarProducto(Inventario inventario)
    {
        Console.Write("Ingrese el nombre del producto a eliminar: ");
        string nombre = Console.ReadLine();
        inventario.EliminarProducto(nombre);
        Console.WriteLine("Producto eliminado exitosamente.");
    }

    static void ActualizarProducto(Inventario inventario)
    {
        Console.Write("Ingrese el nombre del producto a actualizar: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese la nueva cantidad: ");
        int nuevaCantidad = int.Parse(Console.ReadLine());

        inventario.ActualizarProducto(nombre, nuevaCantidad);
        Console.WriteLine("Producto actualizado exitosamente.");
    }

    static void RealizarCompra(Inventario inventario, HistorialTransacciones historial)
    {
    }

    static void VerHistorial(HistorialTransacciones historial)
    {
    }
}
