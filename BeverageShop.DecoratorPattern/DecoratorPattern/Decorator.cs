using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern.DecoratorPattern
{
    // Interface can be used instead
    public abstract class Decorator : Component
    {
        protected Component Component;

        protected Decorator(Component component)
        {
            Component = component;
        }

        public override void Functionality2()
        {
            Console.WriteLine("Decorator's Functionality 2.");
        }

        public void SetComponent(Component component)
        {
            Component = component;
        }
    }
}
