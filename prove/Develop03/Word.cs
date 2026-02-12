using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Develop03
{
    public class Word(string a)
    {
        private string _word = a;
        private bool _active = true;

        public bool Hide() //returns true if something changed, false if it was already hidden
        {
            bool o = _active;
            _active = false;
            return o;
        }

        public bool Show() //returns true if something changed, false if it was already shown
        {
            bool o = !_active;
            _active = true;
            return o;
        }

        public string Display()
        {
            if (_active)
                return _word;
            else
            {
                //return new string('_', _word.Length);
                //SHOWING CREATIVITY
                string outputString = "";
                foreach(char letter in _word)
                {
                    if(char.IsLetterOrDigit(letter))
                        outputString += '_';
                    else
                        outputString += letter;
                }
                return outputString;
            }
        }
    }
}