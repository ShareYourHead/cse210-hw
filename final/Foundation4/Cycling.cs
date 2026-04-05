using System;

namespace Foundation4
{
    public class Cycling(string date, int minutes, double speed)
        : Activity(date, minutes)
    {
        private double _speedMph = speed;

        public override double GetDistance()
        {
            return _speedMph * GetMinutes() / 60;
        }

        public override double GetSpeed()
        {
            return _speedMph;
        }

        public override double GetPace()
        {
            return 60 / _speedMph;
        }
    }
}
