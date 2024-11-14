using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraTests
{
    [TestClass] 
    public class CalculadoraTests
    {
        [TestMethod] 
        public void TestSumar()
        {
            
            Calculadora calculadora = new Calculadora();
            int a = 5;
            int b = 10;
            int expected = 15;

            
            int result = calculadora.Sumar(a, b);

            
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected, result, "La suma de {0} y {1} debería ser {2}.", a, b, expected);
        }
    }
}
