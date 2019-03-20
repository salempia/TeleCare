using System;

namespace TeleCare.CustomerException
{
    [Serializable]
    public class BaseException : Exception
    {
        public BaseException()
            : base()
        { }

        public BaseException(string message)
            : base(message)
        { }

        public BaseException(string message, int errorCode)
            : base(message)
        {
            this.ErrorCode = errorCode;
        }

        public BaseException(string message, Exception inner)
            : base(message, inner)
        { }

        public BaseException(int errorCode, string message, Exception inner)
            : base(message, inner)
        {
            this.ErrorCode = errorCode;
        }

        public int ErrorCode { get; set; }
    }
}