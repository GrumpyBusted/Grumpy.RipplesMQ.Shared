using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Message Bus Service Register Message 
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class MessageBusServiceHandshakeMessage 
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
        /// Instance Name
        /// </summary>
        public string InstanceName { get; set; }

        /// <summary>
        /// Message Broker Handshake Time
        /// </summary>
        public DateTimeOffset HandshakeDateTime { get; set; }

        /// <summary>
        /// List of active Subscribe Handler
        /// </summary>
        public IEnumerable<SubscribeHandler> SubscribeHandlers { get; set; }

        /// <summary>
        /// List of active Request Handler
        /// </summary>
        public IEnumerable<RequestHandler> RequestHandlers { get; set; }
    }
}