using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FruitBurstBackend;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class GameStateTest
    {

        [TestMethod]
        public void TestMakeFruitAppear()
        {
            GameState gs = new GameState(5, 5);
            gs.MakeFruitsAppear();
            bool result = false;
            for(int i =0; i<5; i++){
                for(int j =0; j<5; j++){
                    if(gs.Grid[i,j].IsVisible == true){
                        result = true;
                    }
                }
            }
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSetInvisibleAt()
        {
            GameState gs = new GameState(5, 5);
            gs.Grid[1,4].MakeVisible();
            gs.SetInvisibleAt(1, 4);
            Assert.IsFalse(gs.Grid[2, 3].IsVisible);
        }

        [TestMethod]
        public void TestUpdateScore()
        {
            GameState gs = new GameState(5, 5);
            IFruit f = new Fruit();
            gs.UpdateScore(f);

            Assert.IsTrue(gs.ScoreAndLevelCounter.Score>0);
        }

        [TestMethod]
        public void TestIncrementLevel()
        {
            GameState gs = new GameState(5, 5);
            gs.IncrementLevel();
            Assert.IsTrue(gs.ScoreAndLevelCounter.Level>0);

        }

        
    }
}