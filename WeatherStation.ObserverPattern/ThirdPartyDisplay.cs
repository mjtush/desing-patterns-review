﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherStation.ObserverPattern
{
    public class ThirdPartyDisplay : IObserver, IDisplayElement
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
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}