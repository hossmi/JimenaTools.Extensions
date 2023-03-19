using System;
using System.Runtime.Serialization;

namespace JimenaTools.Exceptions
{
    public class NonDefaultValueArgumentException<T> : ArgumentException where T : struct
    {
        public NonDefaultValueArgumentException(string paramName = null)
            : base($"{typeof(T).Name} parameter {paramName ?? ""} must be distinct of '{default(T)}'") { }

        protected NonDefaultValueArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
