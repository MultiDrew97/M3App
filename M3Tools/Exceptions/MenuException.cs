using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class MenuException : Exception
    {

        public MenuException() : base()
        {
        }

        public MenuException(string message) : base(message)
        {
        }

        public MenuException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}