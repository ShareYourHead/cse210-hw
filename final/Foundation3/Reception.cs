using System;

namespace Foundation3
{
    public class Reception(string title, string description, string date, string time, string address, string rsvpEmail)
        : Event(title, description, date, time, address, "Reception")
    {
        private string _rsvpEmail = rsvpEmail;

        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP: {_rsvpEmail}";
        }
    }
}
