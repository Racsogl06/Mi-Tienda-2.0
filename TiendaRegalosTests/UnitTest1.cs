using NUnit.Framework;
namespace TiendaRegalosTests
{
    [TestFixture]
    public class InventarioTests
    {
        private Inventario inventario;

        [SetUp]
        public void Setup()
        {
            inventario = new Inventario();
        }

        [Test]
        public void AgregarProducto_ShouldAddProductToInventory()
        {
            var producto = new Producto("Regalo1", 10.0m, 5);
            inventario.AgregarProducto(producto);

            Assert.AreEqual(1, inventario.ListarProductos().Count);
        }

        [Test]
        public void EliminarProducto_ShouldRemoveProductFromInventory()
        {
            var producto = new Producto("Regalo1", 10.0m, 5);
            inventario.AgregarProducto(producto);
            inventario.EliminarProducto("Regalo1");

            Assert.AreEqual(0, inventario.ListarProductos().Count);
        }

    }
}