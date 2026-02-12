using System;
using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace Develop03
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words = new();
        private SortedSet<int> _hidden = new();
        private Random _rng = new();

        public Scripture(string content, string book, int chapter, int first)
        {
            _reference = new(book, chapter, first);
            _GenerateWordList(content);
        }

        public Scripture(string content, string book, int chapter, int first, int last)
        {
            _reference = new(book, chapter, first, last);
            _GenerateWordList(content);
        }

        private void _GenerateWordList(string content)
        {
            string[] strings = content.Split(' ');
            foreach(string s in strings)
                _words.Add(new(s));
        }

        public bool HideWords(int number = 3) //returns true if at least 1 word's state was changed
        {
            //_rng.Next([min=0],max) generates [min,max)
            for(int i = 0; i < number; i++)
            {
                int comp = _words.Count() - _hidden.Count(); //check that there are still words to hide

                if(comp <= 0)
                {
                    if(i==0)
                        return false;
                    else
                        break;
                }
                
                int selection = _rng.Next(comp); //generate index
                foreach(int n in _hidden) //cast index to domain of unhiden words
                {
                    if (selection >= n)
                        selection++;
                }
                if(_words[selection].Hide()) //hide word
                    _hidden.Add(selection); //make sure I don't hide that word again
                else
                    Environment.FailFast("ABORTED! Program tried to hide word that was already hidden.");
            }
            return true;
        }

        public void ShowAll()
        {
            foreach(Word word in _words)
                word.Show();
            _hidden = new();
        }

        public string Display()
        {
            string outputString = _reference.Display();
            foreach(Word word in _words)
            {
                outputString += ' '+word.Display();
            }
            return outputString;
        }
    }
}