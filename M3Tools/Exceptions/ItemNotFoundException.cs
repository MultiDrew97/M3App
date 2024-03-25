using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class ItemNotFoundException : Exception
    {

        public ItemNotFoundException() : base()
        {
        }

        public ItemNotFoundException(string message) : base(message)
        {
        }

        public ItemNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}