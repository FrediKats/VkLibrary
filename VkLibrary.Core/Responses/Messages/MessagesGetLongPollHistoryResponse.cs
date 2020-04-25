using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class MessagesGetLongPollHistoryResponse
    {
        [JsonProperty("history")]
        public int[][] History { get; set; }
        [JsonProperty("groups")]
        public GroupsGroup[] Groups { get; set; }
        [JsonProperty("messages")]
        public MessagesLongpollMessages Messages { get; set; }
        [JsonProperty("profiles")]
        public UsersUserFull[] Profiles { get; set; }
        [JsonProperty("chats")]
        public MessagesChat[] Chats { get; set; }

        ///<summary>
        /// Persistence timestamp
        ///</summary>
        [JsonProperty("new_pts")]
        public int NewPts { get; set; }

        ///<summary>
        /// Has more
        ///</summary>
        [JsonProperty("more")]
        public Boolean More { get; set; }
        [JsonProperty("conversations")]
        public MessagesConversation[] Conversations { get; set; }
    }
}