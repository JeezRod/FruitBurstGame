using System;

namespace FruitBurstBackend
{
    public abstract class FruitDecorator : IFruit{
        protected IFruit iFruit;

        public FruitDecorator(IFruit ifruit){
            iFruit = ifruit;
        }

        public virtual int Points{
            get{return this.iFruit.Points;}
        }

        public virtual bool IsVisible{
            get{return this.iFruit.IsVisible;} set{this.iFruit.IsVisible = value;}
        }

        public virtual void MakeVisible(){
            this.iFruit.IsVisible = true;
        }

        public virtual void MakeInvisible(){
            this.iFruit.IsVisible = false;
        }

    }
}