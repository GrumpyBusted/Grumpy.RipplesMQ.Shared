using System.Diagnostics.CodeAnalysis;

namespace Grumpy.RipplesMQ.Shared.Messages
{
    /// <summary>
    /// Request handler
    /// </summary>
    [SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class RequestHandler
    {
        /// <summary>
        /// Request Name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Queue Name
        /// </summary>
        public string QueueName { get; set; }
    }
}