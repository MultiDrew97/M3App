using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class PasswordException : UserException
    {

        public PasswordException() : base()
        {
        }

        public PasswordException(string message) : base(message)
        {
        }

        public PasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}