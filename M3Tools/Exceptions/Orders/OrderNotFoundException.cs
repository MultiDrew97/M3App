using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class OrderNotFoundException : Exception
    {

        public OrderNotFoundException() : base()
        {
        }

        public OrderNotFoundException(string message) : base(message)
        {
        }

        public OrderNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}