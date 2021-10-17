using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;
using System;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class ScoreAndLevelTest
    {
        [TestMethod]
        public void TestUpdateScore(){
            ScoreAndLevel sl = new ScoreAndLevel();
            IFruit f = new Fruit();
            sl.UpdateScore(f);
            Assert.IsTrue(sl.Score>0);
        }

        [TestMethod]
        public void TestIncrementLevel(){
            ScoreAndLevel sl = new ScoreAndLevel();
            sl.IncrementLevel();
            Assert.IsTrue(sl.Level>0);
        }

    }
}