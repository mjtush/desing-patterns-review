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
        private Component _component;

        protected Decorator(Component component)
        {
            _component = component;
        }

        public override void Functionality2()
        {
            Console.WriteLine("Decorator's Functionality 2.");
        }

        public void SetComponent(Component component)
        {
            _component = component;
        }
    }
}
