public class Producto
{
    public string Nombre { get; private set; }
    public decimal Precio { get; private set; }
    public int Cantidad { get; private set; }

    public Producto(string nombre, decimal precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public void ActualizarCantidad(int cantidad)
    {
        Cantidad += cantidad;
    }

    public void ReducirCantidad(int cantidad)
    {
        if (Cantidad < cantidad)
            throw new InvalidOperationException("No hay suficiente cantidad en inventario.");
        Cantidad -= cantidad;
    }
}
