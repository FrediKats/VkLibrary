using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class FriendsGetRequestsResponse
    {
        ///<summary>
        /// Total requests number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }

        ///<summary>
        /// Total unread requests number
        ///</summary>
        [JsonProperty("count_unread")]
        public int CountUnread { get; set; }
    }
}