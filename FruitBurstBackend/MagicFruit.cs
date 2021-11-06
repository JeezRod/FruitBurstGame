using System;

namespace FruitBurstBackend
{
    public class MagicFruit : FruitDecorator{
        
        public MagicFruit(IFruit ifruit):base(ifruit){
            HP = 20;
        }

       public int HP{
           get; set;
       }

        public override void MakeInvisible()
        {
            if(HP <= 0){
                iFruit.MakeInvisible();
            }else{
                HP -=1;
            }
            
        }


    }

}