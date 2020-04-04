using System;

namespace CommandLineDrawing
{
    public class IllegalShapeException : ApplicationException
    {
        public IllegalShapeException(string message) : base(message)
        {
        }
    }
}