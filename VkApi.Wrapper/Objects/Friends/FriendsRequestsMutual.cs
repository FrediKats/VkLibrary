using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class FriendsRequestsMutual
    {
        ///<summary>
        /// Total mutual friends number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("users")]
        public int[] Users { get; set; }
    }
}