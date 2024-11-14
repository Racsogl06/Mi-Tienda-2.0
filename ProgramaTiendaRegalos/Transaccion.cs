public class Transaccion
{
    public List<Producto> ProductosComprados { get; private set; }
    public decimal TotalPagado { get; private set; }

    public Transaccion(List<Producto> productos, decimal total)
    {
        ProductosComprados = productos;
        TotalPagado = total;
    }
}
