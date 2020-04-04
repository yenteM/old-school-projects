using System;

namespace CommandLineDrawing
{
    public class IllegalCommandException : ApplicationException
    {
        public IllegalCommandException(string message) : base(message)
        {

        }
    }
}