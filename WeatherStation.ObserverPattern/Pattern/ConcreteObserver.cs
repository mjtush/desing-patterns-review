using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern.Pattern
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

        public void Update()
        {
            throw new System.NotImplementedException();
        }
    }
}