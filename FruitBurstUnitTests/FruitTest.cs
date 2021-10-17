using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;
using System;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class FruitTest
    {
        [TestMethod]
        public void TestFruitIsVisible(){
            IFruit f  = new Fruit();
            Assert.IsFalse(f.IsVisible);
        }

        [TestMethod]
        public void TestFruitMakeVisible(){
            IFruit f  = new Fruit();
            f.MakeVisible();
            Assert.IsTrue(f.IsVisible);
        }

        [TestMethod]
        public void TestFruitMakeInvisible(){
            IFruit f  = new Fruit();
            f.IsVisible = true;
            f.MakeInvisible();
            Assert.IsFalse(f.IsVisible);
        }

    }
}