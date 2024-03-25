using System;

namespace SPPBC.M3Tools.Exceptions
{
    [Serializable]
    public class FolderException : FileException
    {

        public FolderException() : base()
        {
        }

        public FolderException(string message) : base(message)
        {
        }

        public FolderException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}