using BeverageShop.DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern
{
    internal class Decaf : Beverage
    {
        private readonly double _cost;

        public Decaf()
        {
            DescriptionField = "Decaf";
            _cost = 1.05;
        }

        public override string Description => DescriptionField;

        public override double Cost()
        {
            return _cost;
        }
    }
}
