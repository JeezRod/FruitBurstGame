using System;

namespace FruitBurstBackend
{
    public class FruitGrid{

        private IFruit[,] grid;
        private Random rand = new Random();
        public FruitGrid(int height, int width){
            grid = new IFruit [height,width];
            GenerateGridFruits();
        }


        public bool GetVisibilityAt(int i, int j){
            return this.grid[i,j].IsVisible;
        }

        public IFruit[,] retGrid(){
            return grid;
        }

        public void GenerateGridFruits(){
            int randNum = 0;
            for(int i = 0 ; i< grid.GetLength(0); i++){
                for(int j = 0 ; j< grid.GetLength(1); j++){
                    randNum = rand.Next(1,4);
                    if(randNum == 1){
                        grid[i,j] = new MagicFruit(new Fruit());
                    }else if(randNum == 2){
                        grid[i,j] = new ExplodingFruit(new Fruit());
                    }
                    else{
                        grid[i,j] = new Fruit();
                    }
                }
            }
        }



    }
}