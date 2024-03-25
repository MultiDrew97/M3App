using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class RoleException : UserException
    {

        public RoleException() : base()
        {
        }

        public RoleException(string message) : base(message)
        {
        }

        public RoleException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}