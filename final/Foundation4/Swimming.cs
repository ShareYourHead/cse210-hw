using System;

namespace Foundation4
{
    public class Swimming(string date, int minutes, int laps)
        : Activity(date, minutes)
    {
        private int _laps = laps;

        public override double GetDistance()
        {
            return _laps * 50.0 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            return GetDistance() / GetMinutes() * 60;
        }

        public override double GetPace()
        {
            return GetMinutes() / GetDistance();
        }
    }
}
