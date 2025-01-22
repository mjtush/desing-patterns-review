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
                ValidateSize(value);
                ValidateNonNegative((int)value);
                _size = value;
            }
        }

        private static void ValidateSize(Size value)
        {
            if (!Enum.IsDefined(typeof(Size), value))
            {
                throw new ArgumentException("Invalid size value.");
            }
        }

        private static void ValidateNonNegative(int value)
        {
            if (int.IsNegative(value))
            {
                throw new ArgumentException("Value cannot be negative.");
            }
        }
    }
}
