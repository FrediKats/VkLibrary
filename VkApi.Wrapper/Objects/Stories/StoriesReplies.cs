using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StoriesReplies
    {
        ///<summary>
        /// Replies number.
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// New replies number.
        ///</summary>
        [JsonProperty("new")]
        public int New { get; set; }
    }
}