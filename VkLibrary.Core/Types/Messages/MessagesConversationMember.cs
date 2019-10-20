using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class MessagesConversationMember
    {
        ///<summary>
        /// Is it possible for user to kick this member
        ///</summary>
        [JsonProperty("can_kick")]
        public Boolean CanKick { get; set; }
        [JsonProperty("invited_by")]
        public int InvitedBy { get; set; }
        [JsonProperty("is_admin")]
        public Boolean IsAdmin { get; set; }
        [JsonProperty("is_owner")]
        public Boolean IsOwner { get; set; }
        [JsonProperty("is_message_request")]
        public Boolean IsMessageRequest { get; set; }
        [JsonProperty("join_date")]
        public int JoinDate { get; set; }

        ///<summary>
        /// Message request date
        ///</summary>
        [JsonProperty("request_date")]
        public int RequestDate { get; set; }
        [JsonProperty("member_id")]
        public int MemberId { get; set; }
    }
}