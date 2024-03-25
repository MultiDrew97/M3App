using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class CustomerNotFoundException : Exception
    {

        public CustomerNotFoundException() : base()
        {
        }

        public CustomerNotFoundException(string message) : base(message)
        {
        }

        public CustomerNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}