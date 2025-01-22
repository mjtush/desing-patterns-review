using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BeverageShop.DecoratorPattern.Beverages;

namespace BeverageShop.DecoratorPattern.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage Beverage;

        protected CondimentDecorator(Beverage beverage)
        {
            Beverage = beverage ?? throw new ArgumentNullException(nameof(beverage));
        }
    }
}
