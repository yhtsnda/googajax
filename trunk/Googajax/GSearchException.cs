using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Googajax
{
    [Serializable]
    public class GSearchException : Exception
    {
        public GSearchException(string message) : base(message) { ErrorCode = -1; }
        public GSearchException(string message, Exception inner) : base(message, inner) { ErrorCode = -1; }
        public GSearchException(string message, int errorCode)
            : base(message)
        {
            ErrorCode = errorCode;
        }

        public int ErrorCode
        {
            get;
            private set;
        }

        public bool IsServerError
        {
            get { return ErrorCode != -1; }
        }
    }
}
