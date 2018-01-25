using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Request Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class RequestMessage
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
        /// Request Id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Request Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Reply Queue
        /// </summary>
        public string ReplyQueue { get; set; }

        /// <summary>
        /// Message Body
        /// </summary>
        public object Body { get; set; }

        /// <summary>
        /// Registration Request Send from Message Bus Time
        /// </summary>
        public DateTimeOffset RequestDateTime { get; set; }
    }
}