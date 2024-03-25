using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class PasswordMismatchException : PasswordException
    {

        public PasswordMismatchException() : base()
        {
        }

        public PasswordMismatchException(string message) : base(message)
        {
        }

        public PasswordMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}