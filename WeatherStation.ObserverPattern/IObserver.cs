using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public interface IObserver
    {
        public void Update(float temp, float hummidity, float pressure);
    }
}