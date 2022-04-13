using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalcuTest
{
    //[TestClass]
    public class MsTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = Calculadora.Program.Something();
            Assert.AreEqual("algo", result);
        }
    }
}
