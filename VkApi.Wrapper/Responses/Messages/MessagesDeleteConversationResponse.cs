using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class MessagesDeleteConversationResponse
    {
        ///<summary>
        /// Id of the last message, that was deleted
        ///</summary>
        [JsonProperty("last_deleted_id")]
        public int LastDeletedId { get; set; }
    }
}