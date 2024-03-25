using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class LoginException : UserException
    {

        public LoginException() : base()
        {
        }

        public LoginException(string message) : base(message)
        {
        }

        public LoginException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}