using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesMessageRequestData
    {
        ///<summary>
        /// Status of message request
        ///</summary>
        [JsonProperty("status")]
        public String Status { get; set; }

        ///<summary>
        /// Message request sender id
        ///</summary>
        [JsonProperty("inviter_id")]
        public int InviterId { get; set; }

        ///<summary>
        /// Message request date
        ///</summary>
        [JsonProperty("request_date")]
        public int RequestDate { get; set; }
    }
}