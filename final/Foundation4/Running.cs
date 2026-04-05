using System;

namespace Foundation4
{
    public class Running(string date, int minutes, double distance)
        : Activity(date, minutes)
    {
        private double _distanceMiles = distance;

        public override double GetDistance()
        {
            return _distanceMiles;
        }

        public override double GetSpeed()
        {
            return _distanceMiles / GetMinutes() * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / _distanceMiles;
        }
    }
}
