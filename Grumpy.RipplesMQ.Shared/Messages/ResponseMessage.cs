using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Response Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ResponseMessage
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
        /// Reply Queue Name
        /// </summary>
        public string ReplyQueue { get; set; }
        
        /// <summary>
        /// Message Body
        /// </summary>
        public object Body { get; set; }
        
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