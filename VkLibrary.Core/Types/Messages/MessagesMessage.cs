using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesMessage
    {
        [JsonProperty("action")]
        public MessagesMessageAction Action { get; set; }

        ///<summary>
        /// Only for messages from community. Contains user ID of community admin, who sent this message.
        ///</summary>
        [JsonProperty("admin_author_id")]
        public int AdminAuthorId { get; set; }
        [JsonProperty("attachments")]
        public MessagesMessageAttachment[] Attachments { get; set; }

        ///<summary>
        /// Unique auto-incremented number for all messages with this peer
        ///</summary>
        [JsonProperty("conversation_message_id")]
        public int ConversationMessageId { get; set; }

        ///<summary>
        /// Date when the message has been sent in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Is it an deleted message
        ///</summary>
        [JsonProperty("deleted")]
        public int Deleted { get; set; }

        ///<summary>
        /// Message author's ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }

        ///<summary>
        /// Forwarded messages
        ///</summary>
        [JsonProperty("fwd_messages")]
        public MessagesForeignMessage[] FwdMessages { get; set; }
        [JsonProperty("geo")]
        public BaseGeo Geo { get; set; }

        ///<summary>
        /// Message ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Is it an important message
        ///</summary>
        [JsonProperty("important")]
        public Boolean Important { get; set; }
        [JsonProperty("is_hidden")]
        public Boolean IsHidden { get; set; }
        [JsonProperty("keyboard")]
        public MessagesKeyboard Keyboard { get; set; }

        ///<summary>
        /// Members number
        ///</summary>
        [JsonProperty("members_count")]
        public int MembersCount { get; set; }

        ///<summary>
        /// Information whether the message is outcoming
        ///</summary>
        [JsonProperty("out")]
        public int Out { get; set; }
        [JsonProperty("payload")]
        public String Payload { get; set; }

        ///<summary>
        /// Peer ID
        ///</summary>
        [JsonProperty("peer_id")]
        public int PeerId { get; set; }

        ///<summary>
        /// ID used for sending messages. It returned only for outgoing messages
        ///</summary>
        [JsonProperty("random_id")]
        public int RandomId { get; set; }
        [JsonProperty("ref")]
        public String Ref { get; set; }
        [JsonProperty("ref_source")]
        public String RefSource { get; set; }
        [JsonProperty("reply_message")]
        public MessagesForeignMessage ReplyMessage { get; set; }

        ///<summary>
        /// Message text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }

        ///<summary>
        /// Date when the message has been updated in Unixtime
        ///</summary>
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }
    }
}