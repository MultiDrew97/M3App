using System;

namespace SPPBC.M3Tools.Exceptions
{
    public class PathNotFoundException : Exception
    {

        public PathNotFoundException() : base()
        {
        }

        public PathNotFoundException(string message) : base(message)
        {
        }

        public PathNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}