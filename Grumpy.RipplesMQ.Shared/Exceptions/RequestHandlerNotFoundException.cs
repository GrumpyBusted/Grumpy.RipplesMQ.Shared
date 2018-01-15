using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Grumpy.RipplesMQ.Shared.Exceptions
{
    /// <inheritdoc />
    /// <summary>
    /// Request Handler not Found Exception
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public sealed class RequestHandlerNotFoundException : Exception
    {
        private RequestHandlerNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }

        /// <inheritdoc />
        /// <summary>
        /// Request Handler not Found Exception
        /// </summary>
        /// <param name="name">Request Name</param>
        public RequestHandlerNotFoundException(string name) : base("Request Handler not Found")
        {
            Data.Add(nameof(name), name);
        }
    }
}