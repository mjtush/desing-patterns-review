using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern.Pattern
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

        public void RegisterObserver(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveObserver(IObserver observer)
        {
            throw new System.NotImplementedException();
        }

        public void NotifyObserver()
        {
            throw new System.NotImplementedException();
        }
    }
}