using System;
using ConsoleCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodValidAdd()
        {
            Validator val = new Validator();
            Calculator cal = new Calculator();
            object aux1 = "2";            
            object aux2 = "3";            
            Assert.AreEqual<int>(5, cal.Add(Convert.ToInt32(aux1), Convert.ToInt32(aux2)));
        }
    }
}
