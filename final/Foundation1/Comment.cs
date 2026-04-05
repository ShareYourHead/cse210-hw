using System;

namespace Foundation1
{
    public class Comment(string username, string text)
    {
        private string _username = username;
        private string _text = text;

        public string GetDetails()
        {
            return $"{_username}: {_text}";
        }
    }
}
