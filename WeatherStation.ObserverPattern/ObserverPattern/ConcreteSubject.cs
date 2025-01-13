using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class ConcreteSubject : ISubject
    {
        public int State
        {
            get => default;
            set
            {
            }
        }

        private void registerObserver()
        {
            throw new System.NotImplementedException();
        }

        private void removeObserver()
        {
            throw new System.NotImplementedException();
        }

        private void notifyObserver()
        {
            throw new System.NotImplementedException();
        }
    }
}