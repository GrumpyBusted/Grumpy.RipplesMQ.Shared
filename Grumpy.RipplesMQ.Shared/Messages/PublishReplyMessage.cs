using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Publish reply Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class PublishReplyMessage
    {
        /// <summary>
        /// Reply From Message Broker Server Name
        /// </summary>
        public string MessageBrokerServerName { get; set; }

        /// <summary>
        /// Reply From Message Broker Service Name
        /// </summary>
        public string MessageBrokerServiceName { get; set; }

        /// <summary>
        /// Message Id
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Topic/Subject
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// Publish Message Time
        /// </summary>
        public DateTimeOffset PublishDateTime { get; set; }

        /// <summary>
        /// Reply From Message Broker Time
        /// </summary>
        public DateTimeOffset? ReplyDateTime { get; set; }

        /// <summary>
        /// Reply Received in Message Bus
        /// </summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
    }
}