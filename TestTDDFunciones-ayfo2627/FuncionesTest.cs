using TDDFunciones_ayfo2627;
namespace TestTDDFunciones_ayfo2627
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-2, -1L)]  
        [DataRow(0, 1L)]   
        [DataRow(6, 720L)]   
        [DataRow(8,  40320L)]   
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, resultado);
        }
    }
}
