using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class WeatherStationData : IWeatherStation
    {
        public int Temperature
        {
            get => default;
            set
            {
            }
        }

        public int Humidity
        {
            get => default;
            set
            {
            }
        }

        public int Pressure
        {
            get => default;
            set
            {
            }
        }

        private void RegisterObserver()
        {
            throw new System.NotImplementedException();
        }

        private void RemoveObserver()
        {
            throw new System.NotImplementedException();
        }

        private void NotifyObserver()
        {
            throw new System.NotImplementedException();
        }

        private void measurementsChanged()
        {
            throw new System.NotImplementedException();
        }
    }
}