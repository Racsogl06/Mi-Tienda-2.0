namespace Tests
{
    public class Tests
    {    
            private Producto _producto1;
            private Producto _producto2;
            private Pedido _pedido;

            [SetUp]
            public void Setup()
            {
                _producto1 = new Producto("Laptop", 1000m, 20);
                _producto2 = new Producto("Mouse", 50m, 50);
                _pedido = new Pedido();
            }

            [Test(Author = "Darwin Ruiz", Description = "Agregar un producto correctamente con el stock suficiente")]
            public void AgregarProductoStockSufiente()
            {
            int cantidadPedido = 2;
            _pedido.AgregarProducto(_producto1, cantidadPedido);

                Assert.That(_pedido.Items.Count, Is.EqualTo(1));
            }
        
    }
}