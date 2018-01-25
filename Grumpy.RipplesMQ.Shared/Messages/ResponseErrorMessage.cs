using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Exception in Request Handler
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ResponseErrorMessage
    {
        /// <summary>
        /// Server Name
        /// </summary>
        public string RequesterServerName { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        public string RequesterServiceName { get; set; }

        /// <summary>
        /// Server Name
        /// </summary>
        public string ResponderServerName { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        public string ResponderServiceName { get; set; }

        /// <summary>
        /// Request Id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Reply Queue
        /// </summary>
        public string ReplyQueue { get; set; }
        
        /// <summary>
        /// Request Message
        /// </summary>
        public RequestMessage RequestMessage { get; set; }
        
        /// <summary>
        /// Exception from Request Handler
        /// </summary>
        public Exception Exception { get; set; }

        /// <summary>
        /// Request Time
        /// </summary>
        public DateTimeOffset RequestDateTime { get; set; }

        /// <summary>
        /// Response Time
        /// </summary>
        public DateTimeOffset ResponseDateTime { get; set; }

        /// <summary>
        /// Completed Time
        /// </summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
    }
}