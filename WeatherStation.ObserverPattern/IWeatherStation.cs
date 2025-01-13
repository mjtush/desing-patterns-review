using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public interface IWeatherStation
    {
        public void RegisterObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void NotifyObserver();
    }
}