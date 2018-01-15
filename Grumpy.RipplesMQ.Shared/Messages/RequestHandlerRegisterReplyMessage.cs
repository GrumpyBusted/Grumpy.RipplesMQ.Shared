using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Request Handler Register Reply Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class RequestHandlerRegisterReplyMessage 
    {
        /// <summary>
        /// Reply From Message Broker Time Time
        /// </summary>
        public string MessageBrokerServerName { get; set; }

        /// <summary>
        /// Reply From Message Broker Time Time
        /// </summary>
        public string MessageBrokerServiceName { get; set; }

        /// <summary>
        /// Reply From Message Broker Instance Name
        /// </summary>
        public string MessageBrokerInstanceName { get; set; }

        /// <summary>
        /// Registration Request Send from Message Bus Time
        /// </summary>
        public DateTimeOffset RegisterDateTime { get; set; }

        /// <summary>
        /// Registration Request Reply From Message Broker Time
        /// </summary>
        public DateTimeOffset ReplyDateTime { get; set; }

        /// <summary>
        /// Reply Received in Message Bus
        /// </summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
    }
}