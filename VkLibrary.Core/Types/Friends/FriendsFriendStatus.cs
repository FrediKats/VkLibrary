using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
{
    public class FriendsFriendStatus
    {
        [JsonProperty("friend_status")]
        public FriendsFriendStatusStatus FriendStatus { get; set; }

        ///<summary>
        /// Information whether request is unviewed
        ///</summary>
        [JsonProperty("read_state")]
        public int ReadState { get; set; }

        ///<summary>
        /// Message sent with request
        ///</summary>
        [JsonProperty("request_message")]
        public String RequestMessage { get; set; }

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