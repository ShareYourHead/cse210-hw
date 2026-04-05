using System;

namespace Foundation4
{
    public class Activity(string date, int minutes)
    {
        private string _date = date;
        private int _minutes = minutes;

        public int GetMinutes()
        {
            return _minutes;
        }

        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        public string GetSummary()
        {
            return $"{_date} {GetType().Name} ({_minutes} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
