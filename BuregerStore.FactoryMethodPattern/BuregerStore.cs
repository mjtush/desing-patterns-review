using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStore.FactoryMethodPattern
{
    abstract class BuregerStore
    {
        public Burger OrderBurger(string type)
        {
            Burger burger = CreateBurger(type);
            burger.Prepare();
            burger.Cook();
            burger.Box();
            return burger;
        }

        protected abstract Burger CreateBurger(string type);
    }
}
