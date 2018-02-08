using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Subscribe handler
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class SubscribeHandler
    {
        /// <summary>
        /// Subscribe to Topic
        /// </summary>
        public string Topic { get; set; }
        
        /// <summary>
        /// Message Type
        /// </summary>
        public string MessageType { get; set; }
        
        /// <summary>
        /// Subscriber Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Queue Name
        /// </summary>
        public string QueueName { get; set; }

        /// <summary>
        /// Is Subscribe Handler Durable
        /// </summary>
        public bool Durable { get; set; }
    }
}