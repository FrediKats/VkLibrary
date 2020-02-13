using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
{
    public class FriendsRequestsXtrMessage
    {
        ///<summary>
        /// ID of the user by whom friend has been suggested
        ///</summary>
        [JsonProperty("from")]
        public String From { get; set; }

        ///<summary>
        /// Message sent with a request
        ///</summary>
        [JsonProperty("message")]
        public String Message { get; set; }
        [JsonProperty("mutual")]
        public FriendsRequestsMutual Mutual { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}