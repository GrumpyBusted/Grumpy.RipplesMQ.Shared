using System;
using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Subscribe Handler Error Message
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class SubscribeHandlerErrorMessage
    {
        /// <summary>
        /// Server Name
        /// </summary>
        public string PublisherServerName { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        public string PublisherServiceName { get; set; }

        /// <summary>
        /// Server Name
        /// </summary>
        public string HandlerServerName { get; set; }

        /// <summary>
        /// Service Name
        /// </summary>
        public string HandlerServiceName { get; set; }

        /// <summary>
        /// Message Id
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Subscriber Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Message Durable
        /// </summary>
        public bool Durable { get; set; }
        
        /// <summary>
        /// Exception
        /// </summary>
        public Exception Exception { get; set; }
        
        /// <summary>
        /// Message
        /// </summary>
        public PublishMessage Message { get; set; }
        
        /// <summary>
        /// Publish Message Time
        /// </summary>
        public DateTimeOffset PublishDateTime { get; set; }

        /// <summary>
        /// Reply From Subscriber Handler Time
        /// </summary>
        public DateTimeOffset HandlerDateTime { get; set; }

        /// <summary>
        /// Request Completed Time
        /// </summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
    }
} 