using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class FriendsFriendStatus
    {
        [JsonProperty("friend_status")]
        public FriendsFriendStatusStatus FriendStatus { get; set; }

        ///<summary>
        /// MD5 hash for the result validation
        ///</summary>
        [JsonProperty("sign")]
        public String Sign { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}