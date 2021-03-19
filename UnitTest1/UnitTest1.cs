using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskLib;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        // Тест на то что кирпич пройдет в отверстие
        [TestMethod]
        public void TestMethod1()
        {
            Class1 Class1 = new Class1();
            bool f = Class1.Check(2, 3, 4, 2, 3);
            Assert.AreEqual(true, f);

        }

        // Тест на то что кирпич не пройдет в отверстие
        [TestMethod]
        public void TestMethod2()
        {
            Class1 Class1 = new Class1();
            bool f = Class1.Check(2, 1, 4, 2, 3);
            Assert.AreEqual(false, f);

        }


        
    }
}
