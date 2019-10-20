using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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