using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public interface ISubject
    {
        IObserver IObserver { get; set; }

        void registerObserver();
        void removeObserver();
        void notifyObserver();
    }
}