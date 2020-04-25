using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class MessagesUserXtrInvitedBy
    {
        ///<summary>
        /// ID of the inviter
        ///</summary>
        [JsonProperty("invited_by")]
        public int InvitedBy { get; set; }
    }
}