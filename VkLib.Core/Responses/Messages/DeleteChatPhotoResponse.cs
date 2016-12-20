using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Messages
{
    public class DeleteChatPhotoResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("chat")]
        public VkLib.Types.Messages.Chat Chat { get; set; }

        /// <summary>
        /// Service message ID
        /// </summary>
        [JsonProperty("message_id")]
        public int? MessageId { get; set; }

    }
}
