using System;

namespace Foundation3
{
    public class OutdoorGathering(string title, string description, string date, string time, string address, string forecast)
        : Event(title, description, date, time, address, "Outdoor Gathering")
    {
        private string _weatherForecast = forecast;

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nWeather forecast: {_weatherForecast}";
        }
    }
}
