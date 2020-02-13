using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Messages;

namespace VkApi.Wrapper.Responses.Messages
{
    public class MessagesGetHistoryAttachmentsResponse
    {
        [JsonProperty("items")]
        public MessagesHistoryAttachment[] Items { get; set; }

        ///<summary>
        /// Value for pagination
        ///</summary>
        [JsonProperty("next_from")]
        public String NextFrom { get; set; }
    }
}