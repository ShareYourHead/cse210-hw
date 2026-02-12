using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace Develop03
{
    public class Reference(string book, int chapter, int first, int last = 0)
    {
        private string _book = book;
        private int _chapter = chapter;
        private int _firstVerse = first;
        private int _lastVerse = last; //defaults to 0

        public string Display()
        {
            string outputString = $"{_book} {_chapter}:{_firstVerse}";
            if (_lastVerse != 0 && _lastVerse != _firstVerse)
                outputString += $"-{_lastVerse}";
            return outputString;
        }
    }
}