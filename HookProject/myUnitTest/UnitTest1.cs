using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace myUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 1;
            int b = 1;

            int result = 2;

            int expected = a + b;

            Assert.AreEqual(expected, result);
        }
    }
}
