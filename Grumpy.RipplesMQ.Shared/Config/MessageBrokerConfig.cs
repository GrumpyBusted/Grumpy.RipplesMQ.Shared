using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Config
{
    /// <summary>
    /// Configuration for Message Broker
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class MessageBrokerConfig 
    {
        /// <summary>
        /// Message Broker Queue Name
        /// </summary>
        public static string LocaleQueueName => "Grumpy.MessageBroker.Locale";
    }
}
