using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesConversation
    {
        [JsonProperty("peer")]
        public MessagesConversationPeer Peer { get; set; }

        ///<summary>
        /// ID of the last message in conversation
        ///</summary>
        [JsonProperty("last_message_id")]
        public int LastMessageId { get; set; }

        ///<summary>
        /// Last message user have read
        ///</summary>
        [JsonProperty("in_read")]
        public int InRead { get; set; }

        ///<summary>
        /// Last outcoming message have been read by the opponent
        ///</summary>
        [JsonProperty("out_read")]
        public int OutRead { get; set; }

        ///<summary>
        /// Unread messages number
        ///</summary>
        [JsonProperty("unread_count")]
        public int UnreadCount { get; set; }
        [JsonProperty("important")]
        public Boolean Important { get; set; }
        [JsonProperty("unanswered")]
        public Boolean Unanswered { get; set; }
        [JsonProperty("special_service_type")]
        public String SpecialServiceType { get; set; }
        [JsonProperty("message_request")]
        public String MessageRequest { get; set; }

        ///<summary>
        /// Ids of messages with mentions
        ///</summary>
        [JsonProperty("mentions")]
        public int[] Mentions { get; set; }
        [JsonProperty("current_keyboard")]
        public MessagesKeyboard CurrentKeyboard { get; set; }
    }
}