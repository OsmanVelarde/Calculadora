using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapiCalculadora.Controllers;

namespace utCalculator
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;
            //Act=Ejecución
            int result = calc.Add(numa, numb);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
    }
}
