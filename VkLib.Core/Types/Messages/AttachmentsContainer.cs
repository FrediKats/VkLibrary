using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLib.Types.Messages
{
    public class AttachmentsContainer
    {
        /// <summary>
        /// Message id
        /// </summary>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// Message id
        /// </summary>
        [JsonProperty("attachment")]
        public AttachmentsHistory Attachment { get; set; }
    }
}
