using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;
using System;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class FruitBurstTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            FruitGrid fbe = new FruitGrid(5,5);
            IFruit [,] arr = fbe.retGrid();
            
            Assert.IsNotNull(arr[2,2]);

        }

        
    }
}
