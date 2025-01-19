using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern.DecoratorPattern
{
    internal class ConcreteComponent : Component
    {
        public override void Functionality1()
        {
            Console.WriteLine("Component's Functionality 1.");
        }

        public override void Functionality2()
        {
            Console.WriteLine("Component's Functionality 2.");
        }
    }
}
