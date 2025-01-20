using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage? Beverage;

        protected CondimentDecorator(Beverage beverage)
        {

            if (beverage is not null)
            {
                Beverage = beverage;
            }
            else
            {
                throw new ArgumentNullException(nameof(beverage));
            }
        }
        
    }
}
