using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Messages
{
    public class MessagesPinnedMessage
    {
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
        /// Peer ID
        ///</summary>
        [JsonProperty("peer_id")]
        public int PeerId { get; set; }
        [JsonProperty("reply_message")]
        public MessagesForeignMessage ReplyMessage { get; set; }

        ///<summary>
        /// Message text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
        [JsonProperty("keyboard")]
        public MessagesKeyboard Keyboard { get; set; }
    }
}