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
        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = -4;
            int numres = -1;
            //Act=Ejecución
            int result = calc.Add(numa, numb);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet3()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 0;
            int numres = 7;
            //Act=Ejecución
            int result = calc.Add(numa, numb, numc);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet4()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -5;
            int numc = 0;
            int numres = -8;
            //Act=Ejecución
            int result = calc.Add(numa, numb, numc);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet1()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 5;
            int numres = 15;
            //Act=Ejecución
            int result = calc.Multiply(numa, numb);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet2()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = -5;
            int numres = -15;
            //Act=Ejecución
            int result = calc.Multiply(numa, numb);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet3()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 5;
            int numc = 2;
            int numres = 15;
            //Act=Ejecución
            int result = calc.Multiply(numa, numb, numc);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet4()
        {
            //Arrange=Preparación
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = -5;
            int numc = 2;
            int numres = -15;
            //Act=Ejecución
            int result = calc.Multiply(numa, numb,numc);
            //Assert=Verificación
            Assert.AreEqual(numres, result);
        }
    }
}
