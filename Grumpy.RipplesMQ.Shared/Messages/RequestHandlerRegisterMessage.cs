using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Request Handler register Message
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class RequestHandlerRegisterMessage
    {
        /// <summary>
        /// Server Name
        /// </summary>
        public string ServerName { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// Request name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Queue Name
        /// </summary>
        public string QueueName { get; set; }

        /// <summary>
        /// Reply Queue Name
        /// </summary>
        public string ReplyQueue { get; set; }

        /// <summary>
        /// Registration Request Send from Message Bus Time
        /// </summary>
        public DateTimeOffset RegisterDateTime { get; set; }
    }
}