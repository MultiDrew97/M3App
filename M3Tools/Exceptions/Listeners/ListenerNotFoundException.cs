using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class ListenerNotFoundException : Exception
    {

        public ListenerNotFoundException() : base()
        {
        }

        public ListenerNotFoundException(string message) : base(message)
        {
        }

        public ListenerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}