using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern
{
    internal class HouseBlend : Beverage
    {
        private readonly double _cost;

        public HouseBlend()
        {
            description = "HouseBlend";
            _cost = 0.89;
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
