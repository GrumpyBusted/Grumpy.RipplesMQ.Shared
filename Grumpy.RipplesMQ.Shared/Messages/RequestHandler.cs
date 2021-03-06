﻿using System.Diagnostics.CodeAnalysis;

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
        /// Request Message Type
        /// </summary>
        public string RequestType { get; set; }
        
        /// <summary>
        /// Response Message Type
        /// </summary>
        public string ResponseType { get; set; }
        
        /// <summary>
        /// Queue Name
        /// </summary>
        public string QueueName { get; set; }
    }
}