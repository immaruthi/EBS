using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.Unit.EBSTest
{
    [TestClass]
    public class ProductServiceTest
    {
        [TestMethod]
        public void TestIndex()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Assert.AreEqual(c, 30, "Test case failed");
        }
    }
}
