using System;

namespace FruitBurstBackend
{
    public class ScoreAndLevel{
        
        private int score;
        private int level;
        public ScoreAndLevel(){
           score = 0;
           level = 0;
        }

        public int Score{
            get{return score;}
            private set{score = value;}
        }
        
        public int Level{
            get{return level;}
            private set{level = value;}
        }

        public void UpdateScore(IFruit fruit){
            score += fruit.Points; 
        }

        public void IncrementLevel(){
            Level += 1;
        }

    }
}