using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern.Pattern
{
    public interface IObserver
    {
        public void Update();
    }
}