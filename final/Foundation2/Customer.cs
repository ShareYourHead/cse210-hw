using System;

namespace Foundation2
{
    public class Customer(string name, Address address)
    {
        private string _name = name;
        private Address _address = address;

        public string GetName()
        {
            return _name;
        }

        public string GetAddress()
        {
            return _address.GetString();
        }

        public bool InUSA()
        {
            return _address.InUSA();
        }
    }
}
