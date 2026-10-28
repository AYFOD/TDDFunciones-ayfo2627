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
        [DataRow(8, 40320L)]
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            long resultado = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        [DataRow(null, false)]               
        [DataRow("", false)]                 
        [DataRow("abc", false)]              
        [DataRow("abcdefgh", false)]         
        [DataRow("MiClaveSegura#", true)]    
        [DataRow("abcdefg#", true)]          
        public void EsContrasenyaValida_VariosCasos(string contrasenya, bool esperado)
        {
            bool resultado = Funciones.EsContrasenyaValida(contrasenya);
            Assert.AreEqual(esperado, resultado);
        }
    }
}
