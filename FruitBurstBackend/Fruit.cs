using System;

namespace FruitBurstBackend
{
    
    public class Fruit: IFruit{
        private Random rand = new Random();

        public Fruit(){
            IsVisible = false;
        }
        
        public int Points{get {return rand.Next(1,6);}}

        public bool IsVisible{
                get;
                set;
            }

        public void MakeVisible(){
            IsVisible = true;
        }

        public void MakeInvisible(){
            IsVisible = false;
        }

    }

}