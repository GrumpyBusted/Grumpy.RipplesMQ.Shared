using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Publish Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class PublishMessage
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
        /// Message Id
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Topic/Subject
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Is Message Persistent
        /// </summary>
        public bool Persistent { get; set; }

        /// <summary>
        /// Message Body
        /// </summary>
        public string MessageBody { get; set; }
        
        /// <summary>
        /// Message Type
        /// </summary>
        public string MessageType { get; set; }
       
        /// <summary>
        /// Reply Queue Name
        /// </summary>
        public string ReplyQueue { get; set; }
        
        /// <summary>
        /// Publish Message Time
        /// </summary>
        public DateTimeOffset PublishDateTime { get; set; }

        /// <summary>
        /// Number of times this message failed
        /// </summary>
        public int ErrorCount { get; set; }
    }
}