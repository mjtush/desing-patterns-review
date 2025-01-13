using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class CurrentDisplay : IObserver, IDisplayElement
    {
        public WeatherStationData WeatherStationData
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

        public void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}