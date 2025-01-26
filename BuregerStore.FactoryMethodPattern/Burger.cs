using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BuregerStore.FactoryMethodPattern
{
    public abstract class Burger
    {
        public virtual void Prepare()
        {
            throw new NotImplementedException();
        }

        public virtual void Cook()
        {
            throw new NotImplementedException();
        }

        public virtual void Box()
        {
            throw new NotImplementedException();
        }

    }
}
