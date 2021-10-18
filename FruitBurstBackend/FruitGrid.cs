using System;

namespace FruitBurstBackend
{
    public class FruitGrid{

        private IFruit[,] grid;
        private Random rand = new Random();

        private int height;

        private int width;

        public int Height{
            get{return height;}
        }
        
        public int Width{
            get{return width;}
        }
/**
*   The constructor takes two parameters and initializes
*   the array with the two values. then it uses the helper
*   method to populate the array.
*   @param height which represents the row.
*   @param width which represents the column.
*/      
        public FruitGrid(int height, int width){
            grid = new IFruit [height,width];
            this.height = height;
            this.width = width;
            GenerateGridFruits();
        }

/**
*   This method gets the Isvisible variable for a
*   specific position of a fruit object in the grid.
*   @param i which represents the row.
*   @param j which represents the column.
*/
        public bool GetVisibilityAt(int i, int j){
            return this.grid[i,j].IsVisible;
        }

/**
*   Indexer to get the Fruit from the grid.
*   @param y which represents the row.
*   @param x which represents the column.
*/
        public IFruit this[int y, int x]{
            get{return grid[y,x];}
        }

/**
*   This method randomly assigns all the fruits to the grid
*   array. It assigns MagicFruit, ExplodingFruit and Fruit.
*/
        public void GenerateGridFruits(){
            int randNum = 0;
            for(int i = 0 ; i< grid.GetLength(0); i++){
                for(int j = 0 ; j< grid.GetLength(1); j++){
                    randNum = rand.Next(1,10);
                    if(randNum == 1){
                        grid[i,j] = new MagicFruit(new Fruit());
                    }else if(randNum == 2){
                        grid[i,j] = new ExplodingFruit(new Fruit());
                    }else if(randNum ==3){
                        grid[i,j] = new ExplodingFruit(new MagicFruit(new Fruit()));
                    }
                    else{
                        grid[i,j] = new Fruit();
                    }
                }
            }
        }




    }
}