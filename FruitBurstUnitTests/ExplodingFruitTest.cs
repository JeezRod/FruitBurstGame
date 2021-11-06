using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;
using System;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class ExplodingFruitTest
    {
        [TestMethod]
        public void TestExplodingFruitIsVisible()
        {
            
            IFruit exploF = new ExplodingFruit(new Fruit());
            Assert.IsFalse(exploF.IsVisible);

        }

        [TestMethod]
        public void TestExplodingFruitMakeVisible()
        {
            IFruit exploF = new ExplodingFruit(new Fruit());
            exploF.MakeVisible();
            Assert.IsTrue(exploF.IsVisible);

        }

        [TestMethod]
        public void TestExplodingFruitMakeInvisible()
        {
            IFruit exploF = new ExplodingFruit(new Fruit());
            exploF.IsVisible=true;
            exploF.MakeInvisible();
            Assert.IsFalse(exploF.IsVisible);

        }


        [TestMethod]
        public void TestExplodingFruitPoint()
        {
            IFruit exploF = new ExplodingFruit(new Fruit());
            int numb = exploF.Points;
            Assert.IsTrue(numb<0);

        }
        
    }
}
