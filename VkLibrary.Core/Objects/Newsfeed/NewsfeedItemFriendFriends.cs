using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemFriendFriends
    {
        ///<summary>
        /// Number of friends has been added
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public BaseUserId[] Items { get; set; }
    }
}