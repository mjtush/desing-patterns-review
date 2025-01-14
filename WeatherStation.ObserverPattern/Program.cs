namespace WeatherStation.ObserverPattern
{
    internal class Program
    {
        static void Main()
        {
            var weatherStationData = new WeatherStationData();
            _ = new CurrentDisplay(weatherStationData);
            _ = new ForecastDisplay(weatherStationData);
            _ = new StatisticsDisplay(weatherStationData);

            weatherStationData.SetMeasurements(32, pressure: 1000, hummidity: 80);
            weatherStationData.SetMeasurements(32, 89, 999);
            weatherStationData.SetMeasurements(25, 70, 990);
        }
    }
}
