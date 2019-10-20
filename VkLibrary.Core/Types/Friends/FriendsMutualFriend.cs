using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class FriendsMutualFriend
    {
        ///<summary>
        /// Total mutual friends number
        ///</summary>
        [JsonProperty("common_count")]
        public int CommonCount { get; set; }
        [JsonProperty("common_friends")]
        public int[] CommonFriends { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}