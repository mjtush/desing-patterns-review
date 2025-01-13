using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPressure = 1_014f;
        private float _lastPressure;
        private float _forecastedPressure;

        private readonly WeatherStationData _weatherStationData;

        public ForecastDisplay(WeatherStationData weatherStationData)
        {
            _weatherStationData = weatherStationData;
            _weatherStationData.RegisterObserver(this);
        }
        public void Update()
        {
            _lastPressure = _currentPressure;
            _currentPressure = _weatherStationData.Pressure;
            _forecastedPressure = ForecastPressure();
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Last pressure: {_lastPressure:F1} hPa,\nCurrent pressure: {_currentPressure:F1} hPa,\nForecasted pressure {_forecastedPressure:F1} hPa");
            Console.WriteLine("------------------\n");
        }

        private float ForecastPressure()
        {
            var rnd = new Random();
            float minVal = 0.88f;
            float maxVal = 1.12f;
            float randomFloat = minVal + (float)(rnd.NextDouble() * (maxVal - minVal));
            return _currentPressure * randomFloat;
        }
    }
}