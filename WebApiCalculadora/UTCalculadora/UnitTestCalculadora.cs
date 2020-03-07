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
    }
}
