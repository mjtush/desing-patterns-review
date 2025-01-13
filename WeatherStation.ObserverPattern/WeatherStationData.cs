using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class WeatherStationData : IWeatherStation
    {
        private List<IObserver> _observers;
        private float _temp;
        private float _pressure;
        private float _hummidity;

        public float Temperature
        {
            get => _temp;
        }

        public float Humidity
        {
            get => _hummidity;
        }

        public float Pressure
        {
            get => _pressure;
        }

        public WeatherStationData()
        {
                _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temp, float hummidity, float pressure)
        {
            _temp = temp;
            _hummidity = hummidity;
            _pressure = pressure;

            NotifyObservers();
        }
    }
}