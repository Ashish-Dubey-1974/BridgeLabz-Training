using System;

namespace BookBuddy
{
    public class InvalidBookFormatException : Exception
    {
        public InvalidBookFormatException(string message) : base(message) { }
    }
}