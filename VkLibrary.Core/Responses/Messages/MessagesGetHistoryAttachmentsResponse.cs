using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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