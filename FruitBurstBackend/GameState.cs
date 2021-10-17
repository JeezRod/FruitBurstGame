using System;

namespace FruitBurstBackend
{
    public class GameState{

        private FruitGrid grid;
        private ScoreAndLevel scoreAndLevelCounter;
        private Random rand = new Random();

        private int length;
        private int width;

        public GameState(int length, int width){
            this.length = length;
            this.width = width;
            grid = new FruitGrid(length,width);
            scoreAndLevelCounter = new ScoreAndLevel();
        }
        public FruitGrid Grid{
            get{return grid;}
        }

        public ScoreAndLevel ScoreAndLevelCounter{
            get{return scoreAndLevelCounter;}
        }

/**
*   This method looks randomly for a fruit in the grid 
*   and makes it visible. It goes to everysingle fruit
*   until it finds an available one and makes it visible.
*/
        public void MakeFruitsAppear(){
            bool state = true;
            int count = 0;
            while(state && count<length*width){
                int i = rand.Next(length);
                int j = rand.Next(width);
                if(grid[i,j].IsVisible == false){
                    grid[i,j].MakeVisible();
                    state = false;
                }else{
                    count++;
                }
            }
        }

/**
*   This method sets a fruit invisible taking the
*   the position on the grid.
*/

        public void SetInvisibleAt(int i, int j){
            grid[i,j].MakeInvisible();
        }
/**
*   This method updates the score using the scoreAndLevel
*   object to update it. It takes a fruit object and depending
*   on the points that the fruit has, it changes the Score.
*/
        public void UpdateScore(IFruit fruit){
            scoreAndLevelCounter.UpdateScore(fruit);
        }
/**
*   This method incrementes the level using the scoreAndLevel
*   object to update it.
*/
        public void IncrementLevel(){
            scoreAndLevelCounter.IncrementLevel();
        }

    }
}