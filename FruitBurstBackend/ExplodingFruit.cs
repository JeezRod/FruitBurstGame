using System;

namespace FruitBurstBackend
{
    public class ExplodingFruit : FruitDecorator{
        public ExplodingFruit(IFruit ifruit):base(ifruit){

        }

        public override int Points => -base.Points;

    }

}