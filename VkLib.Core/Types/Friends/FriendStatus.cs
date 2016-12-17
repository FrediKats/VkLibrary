using System;
using Newtonsoft.Json;

namespace VkLib.Types.Friends 
{
    public class FriendStatus
    {
        /// <summary>
        /// Information whether request is unviewed
        /// </summary>
        [JsonProperty("read_state")]
        public int? ReadState { get; set; }

        /// <summary>
        /// MD5 hash for the result validation
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Message sent with request
        /// </summary>
        [JsonProperty("request_message")]
        public string RequestMessage { get; set; }

        /// <summary>
        /// Friend status with the user
        /// </summary>
        [JsonProperty("friend_status")]
        public int? FriendStatus { get; set; }

    }
}
