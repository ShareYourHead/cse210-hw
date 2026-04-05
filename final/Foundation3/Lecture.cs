using System;

namespace Foundation3
{
    public class Lecture(string title, string description, string date, string time, string address, string speaker, int capacity)
        : Event(title, description, date, time, address, "Lecture")
    {
        private string _speakerName = speaker;
        private int _capacity = capacity;

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
        }
    }
}
