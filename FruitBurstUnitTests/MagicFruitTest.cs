using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;
using System;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class MagicFruitTest
    {

        [TestMethod]
        public void TestMagicFruitIsVisible()
        {
            IFruit mgFruit = new MagicFruit(new Fruit());
            Assert.IsFalse(mgFruit.IsVisible);
        }

        [TestMethod]
        public void TestMagicFruitHP()
        {     
            MagicFruit magicF = new MagicFruit(new Fruit());
            Assert.AreEqual(20, magicF.HP);
        }

        [TestMethod]
        public void TestMagicFruitMakeInvisible()
        {
            IFruit mgFruit = new MagicFruit(new Fruit());
            mgFruit.IsVisible = true;
            mgFruit.MakeInvisible();

            Assert.AreEqual(true, mgFruit.IsVisible);
        }

        [TestMethod]
        public void TestMagicFruitMakeVisible()
        {
            IFruit mgFruit = new MagicFruit(new Fruit());
            mgFruit.MakeVisible();
            Assert.IsTrue(mgFruit.IsVisible);

        }

        
    }
}
