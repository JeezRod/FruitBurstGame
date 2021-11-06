using Microsoft.VisualStudio.TestTools.UnitTesting;
using FruitBurstBackend;
using System;

namespace FruitBurstUnitTests
{
    [TestClass]
    public class FruitGridTest{

        [TestMethod]
        public void TestGetVisibilityAt(){
            FruitGrid fg = new FruitGrid(4,6);
            bool result = fg.GetVisibilityAt(1,4);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestGenerateFruits(){
            FruitGrid fg = new FruitGrid(4,6);
            IFruit result = fg[1,4];
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void TestValidateHeightWidht(){
            FruitGrid fg = new FruitGrid(1,4);
            Assert.IsFalse(fg[0,3].IsVisible);
        }

        [TestMethod]
        public void TestGenerateGridFruit()
        {
            FruitGrid grid = new FruitGrid(4, 8);
            bool result = grid.GetVisibilityAt(2, 5);
            for(int i=0; i<4 ; i++){
                for(int j=0; j<8; j++){
                    Console.WriteLine(grid[i,j]);
                }
            }
            Assert.IsFalse(result, "The GetVisibilty method returns true");
        }

    }
}