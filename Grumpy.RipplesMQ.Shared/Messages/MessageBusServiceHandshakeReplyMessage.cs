using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Message Bus Service Register Reply Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class MessageBusServiceHandshakeReplyMessage 
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
        /// Handshake Send Time
        /// </summary>
        public DateTimeOffset SendDateTime { get; set; }

        /// <summary>
        /// Reply From Message Broker Time
        /// </summary>
        public DateTimeOffset ReplyDateTime { get; set; }

        /// <summary>
        /// Reply Received in Message Bus Time
        /// </summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
    }
}