using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageShop.DecoratorPattern.Beverages
{
    public enum Size
    {
        Small,
        Medium,
        Big
    }

    public abstract class Beverage
    {
        private Size _size = Size.Small;
        protected string DescriptionField = "Unknown Beverage";

        public abstract string Description { get; }

        public abstract double Cost();

        public Size Size
        {
            get => _size;

            set
            {
                if (int.IsNegative((int)value))
                {
                    throw new ArgumentException("Value cannot be negative.");
                }

                _size = value;
            }
                
        }
    }
}
