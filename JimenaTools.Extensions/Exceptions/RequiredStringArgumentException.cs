using System;
using System.Runtime.Serialization;

namespace JimenaTools.Extensions.Exceptions
{
    public class RequiredStringArgumentException : ArgumentException
    {
        public RequiredStringArgumentException(string paramName = null)
            : base($"{nameof(String)} parameter {paramName ?? ""} cannot be empty.") { }

        protected RequiredStringArgumentException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
