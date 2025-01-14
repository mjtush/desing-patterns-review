using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class CurrentDisplay : IObserver, IDisplayElement
    {
        private float _temp;
        private float _hummidity;
        private WeatherStationData _weatherStationData;

        public CurrentDisplay(WeatherStationData weatherStationData)
        {
            _weatherStationData = weatherStationData;
            _weatherStationData.RegisterObserver(this);
        }
        public void Update()
        {
            _temp = _weatherStationData.Temperature;
            _hummidity = _weatherStationData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($@"Current weather conditions
            Temperature: {_temp } C,
            Humidity: {_hummidity} %");
            Console.WriteLine("------------------\n");
        }

       
    }
}