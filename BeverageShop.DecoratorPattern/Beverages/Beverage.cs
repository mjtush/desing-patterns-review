using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern.Beverages
{
    public abstract class Beverage
    {
        protected string DescriptionField = "Unknown Beverage";

        public abstract string Description { get; }

        public abstract double Cost();
    }
}
