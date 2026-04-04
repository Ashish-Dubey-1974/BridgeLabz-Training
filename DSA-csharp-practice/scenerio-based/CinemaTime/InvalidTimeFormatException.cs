using System;

namespace CinemaTime
{
    public class InvalidTimeFormatException : Exception
    {
        public InvalidTimeFormatException(string message) : base(message) { }
    }
}