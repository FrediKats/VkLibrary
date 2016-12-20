using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Friends 
{
    public class FriendStatus
    {
        /// <summary>
        /// MD5 hash for the result validation
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// Information whether request is unviewed
        /// </summary>
        [JsonProperty("read_state")]
        public int? ReadState_ { get; set; }

        /// <summary>
        /// Message sent with request
        /// </summary>
        [JsonProperty("request_message")]
        public string RequestMessage_ { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId_ { get; set; }

        /// <summary>
        /// Friend status with the user
        /// </summary>
        [JsonProperty("friend_status")]
        public int? FriendStatus_ { get; set; }

    }
}
