using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Message Bus Service Register Message 
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class MessageBusServiceRegisterMessage 
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
        /// Reply Queue Name
        /// </summary>
        public string ReplyQueue { get; set; }

        /// <summary>
        /// Registration Request Send from Message Bus Time
        /// </summary>
        public DateTimeOffset RegisterDateTime { get; set; }
    }
}