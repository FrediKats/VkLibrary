using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class MessagesSearchConversationsResponse
    {
        ///<summary>
        /// Total results number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public MessagesConversation[] Items { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("groups")]
        public GroupsGroupFull[] Groups { get; set; }
    }
}