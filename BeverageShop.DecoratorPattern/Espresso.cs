using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern
{
    internal class Espresso : Beverage
    {
        private readonly double _cost;

        public Espresso()
        {
            description = "Espresso";
            _cost = 1.99;
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
