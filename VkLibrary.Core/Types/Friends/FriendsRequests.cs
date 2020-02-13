using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
{
    public class FriendsRequests
    {
        ///<summary>
        /// ID of the user by whom friend has been suggested
        ///</summary>
        [JsonProperty("from")]
        public String From { get; set; }
        [JsonProperty("mutual")]
        public FriendsRequestsMutual Mutual { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}