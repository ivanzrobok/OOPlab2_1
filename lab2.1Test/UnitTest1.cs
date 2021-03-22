using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP.Lab2._1;
using System;

namespace lab2._1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Time time = new Time(2, 30);
            Assert.AreEqual(time.Minutes(), 150);
        }
    }
}
