using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesMessageAction
    {
        ///<summary>
        /// Message ID
        ///</summary>
        [JsonProperty("conversation_message_id")]
        public int ConversationMessageId { get; set; }

        ///<summary>
        /// Email address for chat_invite_user or chat_kick_user actions
        ///</summary>
        [JsonProperty("email")]
        public String Email { get; set; }

        ///<summary>
        /// User or email peer ID
        ///</summary>
        [JsonProperty("member_id")]
        public int MemberId { get; set; }

        ///<summary>
        /// Message body of related message
        ///</summary>
        [JsonProperty("message")]
        public String Message { get; set; }
        [JsonProperty("photo")]
        public MessagesMessageActionPhoto Photo { get; set; }

        ///<summary>
        /// New chat title for chat_create and chat_title_update actions
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("type")]
        public MessagesMessageActionStatus Type { get; set; }
    }
}