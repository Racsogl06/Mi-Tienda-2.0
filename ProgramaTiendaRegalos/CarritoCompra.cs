using System.Collections.Generic;

public class CarritoCompra
{
    private List<Producto> productosSeleccionados = new List<Producto>();

    public void AgregarProducto(Producto producto, int cantidad)
    {
        producto.ReducirCantidad(cantidad);
        productosSeleccionados.Add(new Producto(producto.Nombre, producto.Precio, cantidad));
    }

    public decimal CalcularTotal()
    {
        decimal total = 0;
        foreach (var producto in productosSeleccionados)
        {
            total += producto.Precio * producto.Cantidad;
        }
        return total * 1.12m; // Incluyendo impuesto del 12%
    }

    public List<Producto> ObtenerProductos()
    {
        return productosSeleccionados;
    }
}
