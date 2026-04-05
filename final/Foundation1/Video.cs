using System;
using System.Collections.Generic;

namespace Foundation1
{
    public class Video(string title, string author, int length)
    {
        private string _title = title;
        private string _author = author;
        private int _length = length;
        private List<Comment> _comments = new List<Comment>();

        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

        public void AddComment(string username, string text)
        {
            _comments.Add(new Comment(username, text));
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Comments ({GetCommentCount()}):");
            foreach (Comment comment in _comments)
            {
                Console.WriteLine($"  {comment.GetDetails()}");
            }
        }
    }
}
