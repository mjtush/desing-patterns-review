using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _currentTemp = 20f;
        private readonly List<float> _historicalTemperatures = [];
        private float _averageTemp;
        private float _maxTemp;
        private float _minTemp;

        private readonly WeatherStationData _weatherStationData;

        public StatisticsDisplay(WeatherStationData weatherStationData)
        {
            _weatherStationData = weatherStationData;
            _weatherStationData.RegisterObserver(this);
            _historicalTemperatures.Add(_currentTemp);
        }

        public void Update()
        {
            _currentTemp = _weatherStationData.Temperature;
            _historicalTemperatures.Add(_currentTemp);

            CalculateAverageTemp();
            CalculateMinTemp();
            CalculateMaxTemp();
            
            Display();
        }

        private void CalculateAverageTemp()
        {
            _averageTemp =  _historicalTemperatures.Average();
        }

        private void CalculateMinTemp()
        {
            _minTemp = _historicalTemperatures.Min();
        }

        private void CalculateMaxTemp()
        {
            _maxTemp = _historicalTemperatures.Max();
        }

        public void Display()
        {
            Console.WriteLine($"Min/Avg/Max Temperature: {_minTemp}/{_averageTemp}/{_maxTemp} C.");
            Console.WriteLine("------------------\n");
        }
    }
}