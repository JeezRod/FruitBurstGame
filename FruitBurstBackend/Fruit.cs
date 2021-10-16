using System;

namespace FruitBurstBackend
{
    
    public class Fruit: IFruit{
        private Random rand = new Random();
        
        public int Points{get {return rand.Next(1,6);}}

        public bool IsVisible{
                get {return IsVisible;}
                set{IsVisible = false;}
            }

        public void MakeVisible(){
            IsVisible = true;
        }

        public void MakeInvisible(){
            IsVisible = false;
        }

    }

}