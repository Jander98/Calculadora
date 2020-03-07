using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiCalculadora.Controllers;

namespace UTCalculadora
{
    [TestClass]
    public class UnitTestCalculadora
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 7;
            //Act=ejecucion
            int result = calc.Add(numa, numb);
            //Assert=verificacion
            Assert.AreEqual(numres, result);
            
        }
        [TestMethod]
        public void TestAddGet2()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = -7;
            //Act=ejecucion
            int result = calc.Add(numa, numb);
            //Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestAddGet3()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 2;
            int numres = 7;
            //Act=ejecucion
            int result = calc.Add(numa, numb, numc);
            //Assert=verificacion
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestAddGet4()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -2;
            int numres = -7;
            //Act=ejecucion
            int result = calc.Add(numa, numb, numc);
            //Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet1()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numres = 12;
            //Act=ejecucion
            int result = calc.Multiply(numa, numb);
            //Assert=verificacion
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestMultiplyGet2()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numres = 12;
            //Act=ejecucion
            int result = calc.Multiply(numa, numb);
            //Assert=verificacion
            Assert.AreEqual(numres, result);
        }
        [TestMethod]
        public void TestMultiplyGet3()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = 3;
            int numb = 4;
            int numc = 2;
            int numres = 12;
            //Act=ejecucion
            int result = calc.Multiply(numa, numb, numc);
            //Assert=verificacion
            Assert.AreEqual(numres, result);

        }
        [TestMethod]
        public void TestMultiplyGet4()
        {
            //Arrange =preparacion
            CalculatorController calc = new CalculatorController();
            int numa = -3;
            int numb = -4;
            int numc = -2;
            int numres = 12;
            //Act=ejecucion
            int result = calc.Multiply(numa, numb, numc);
            //Assert=verificacion
            Assert.AreEqual(numres, result);
        }
    }
}
