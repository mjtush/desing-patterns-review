using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern
{
    public abstract class Beverage
    {
        protected string description = "Unknown beverage";

        public string Description { get => description; }

        public abstract double Cost();
    }
}
