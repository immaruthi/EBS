using System;
using Application.ProductService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Application.TestBase
{
    [TestClass]
    public class SampleTest
    {
        [TestMethod]
        public void GetAllProducts()
        {
            var obj = ProductServices.GetAllProducts();
            Assert.IsNotNull(obj.Count, "Count shouldn't be null");
        }

        [TestMethod]
        public void GetAllProducts2()
        {
            var obj = ProductServices.GetAllProducts();
            Assert.IsNotNull(obj.Count, "Count shouldn't be null");
        }
    }
}
