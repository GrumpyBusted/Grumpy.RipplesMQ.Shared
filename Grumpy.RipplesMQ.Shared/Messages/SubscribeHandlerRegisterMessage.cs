using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Subscribe Handler Register Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class SubscribeHandlerRegisterMessage
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
        /// Subscriber Name
        /// </summary>
        public string Name { get; set; }
                
        /// <summary>
        /// Topic/Subject
        /// </summary>
        public string Topic { get; set; }
        
        /// <summary>
        /// Is subscriber durable (Permanent)
        /// </summary>
        public bool Durable { get; set; }

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