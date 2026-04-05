using System;

namespace Foundation3
{
    public class Event(string title, string description, string date, string time, string address, string eventType = "Event")
    {
        private string _title = title;
        private string _description = description;
        private string _date = date;
        private string _time = time;
        private string _address = address;
        protected string _eventType = eventType;

        public string GetStandardDetails()
        {
            return $"~~~ {_title} ~~~\n{_description}\n{_date} at {_time}\n{_address}";
        }

        public virtual string GetFullDetails()
        {
            return $"{GetStandardDetails()}\n~ {_eventType} ~";
        }

        public string GetShortDescription()
        {
            return $"{_eventType} - {_title} - {_date}";
        }
    }
}
