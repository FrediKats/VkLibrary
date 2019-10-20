using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class MessagesDeleteChatPhotoResponse
    {
        ///<summary>
        /// Service message ID
        ///</summary>
        [JsonProperty("message_id")]
        public int MessageId { get; set; }
        [JsonProperty("chat")]
        public MessagesChat Chat { get; set; }
    }
}