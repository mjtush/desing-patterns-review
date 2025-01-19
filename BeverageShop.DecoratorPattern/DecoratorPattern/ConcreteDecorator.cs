using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern.DecoratorPattern
{
    internal class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component) : base(component)
        {
        }

        public override void Functionality1()
        {
            Console.WriteLine("ConcreteDecorator's Functionality 1");
        }
    }
}
