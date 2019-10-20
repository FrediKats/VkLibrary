using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesForeignMessage
    {
        [JsonProperty("attachments")]
        public MessagesMessageAttachment[] Attachments { get; set; }

        ///<summary>
        /// Conversation message ID
        ///</summary>
        [JsonProperty("conversation_message_id")]
        public int ConversationMessageId { get; set; }

        ///<summary>
        /// Date when the message was created
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Message author's ID
        ///</summary>
        [JsonProperty("from_id")]
        public int FromId { get; set; }
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

        ///<summary>
        /// Date when the message has been updated in Unixtime
        ///</summary>
        [JsonProperty("update_time")]
        public int UpdateTime { get; set; }
    }
}