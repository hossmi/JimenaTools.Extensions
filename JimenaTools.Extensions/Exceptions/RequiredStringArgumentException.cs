using System;
using System.Runtime.Serialization;

namespace JimenaTools.Exceptions
{
    public class RequiredStringArgumentException : ArgumentException
    {
        public RequiredStringArgumentException()
            : base($"{nameof(String)} parameter cannot be null or empty.") { }

        public RequiredStringArgumentException(string paramName)
            : base($"{nameof(String)} parameter '{paramName}' cannot be empty.") { }

        protected RequiredStringArgumentException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
