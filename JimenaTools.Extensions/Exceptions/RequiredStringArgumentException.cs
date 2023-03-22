using System;
using System.Runtime.Serialization;

namespace JimenaTools.Exceptions
{
    /// <summary>
    /// Exception thrown when a string parameter is null, empty or white space
    /// </summary>
    [Serializable]
    public class RequiredStringArgumentException : ArgumentException
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public RequiredStringArgumentException()
            : base($"{nameof(String)} parameter cannot be null or empty.") { }

        /// <summary>
        /// Constructor for named parameters.
        /// </summary>
        /// <param name="paramName">Name of the parameter.</param>
        public RequiredStringArgumentException(string paramName)
            : base($"{nameof(String)} parameter '{paramName}' cannot be empty.") { }

        /// <summary>
        /// Special constructor
        /// </summary>
        protected RequiredStringArgumentException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
