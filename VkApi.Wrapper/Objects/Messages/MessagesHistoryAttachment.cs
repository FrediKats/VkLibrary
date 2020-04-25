using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesHistoryAttachment
    {
        [JsonProperty("attachment")]
        public MessagesHistoryMessageAttachment Attachment { get; set; }

        ///<summary>
        /// Message ID
        ///</summary>
        [JsonProperty("message_id")]
        public int MessageId { get; set; }

        ///<summary>
        /// Message author's ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }
    }
}