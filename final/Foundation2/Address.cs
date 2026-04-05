using System;

namespace Foundation2
{
    public class Address(string street, string city, string state, string country)
    {
        private string _street = street;
        private string _city = city;
        private string _stateProvince = state;
        private string _country = country;

        public bool InUSA()
        {
            if(_country == "US") return true;
            if(_country == "USA") return true;
            if(_country == "United States") return true;
            if(_country == "United States of America") return true;
            return false;
        }

        public string GetString()
        {
            return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}
