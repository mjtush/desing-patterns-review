using BurgerStoreApp.FactoryMethodPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerStoreApp.FactoryMethodPattern.AbstractFactory
{
    public abstract class BurgerStore
    {
        public Burger OrderBurger(string type)
        {
            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException("Burger type cannot be null or empty", nameof(type));
            }

            Burger burger = CreateBurger(type);
            burger.Prepare();
            burger.Grill();
            burger.Box();

            return burger;
        }

        protected abstract Burger CreateBurger(string type);
    }
}
