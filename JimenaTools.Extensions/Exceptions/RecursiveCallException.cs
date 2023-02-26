using System;
using System.Runtime.Serialization;

namespace JimenaTools.Extensions.Exceptions
{
    public class RecursiveCallException : Exception
    {
        public RecursiveCallException(int recursionLevel) : base($"Maximum recursion level reached.")
        {
            RecursionLevel = recursionLevel;
        }

        protected RecursiveCallException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public int RecursionLevel { get; }
    }
}
