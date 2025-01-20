using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern
{
    internal class DarkRoast : Beverage
    {
        private readonly double _cost;

        public DarkRoast()
        {
            description = "DarkRoast";
            _cost = 0.99;
        }

        public override double Cost()
        {
            return _cost;
        }
    }
}
