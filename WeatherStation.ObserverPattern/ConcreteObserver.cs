using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class ConcreteObserver : IObserver
    {
        public ConcreteSubject ConcreteSubject
        {
            get => default;
            set
            {
            }
        }

        private void update()
        {
            throw new System.NotImplementedException();
        }
    }
}