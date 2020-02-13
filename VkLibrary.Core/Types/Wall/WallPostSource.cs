using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Wall
{
    public class WallPostSource
    {
        ///<summary>
        /// Additional data
        ///</summary>
        [JsonProperty("data")]
        public String Data { get; set; }

        ///<summary>
        /// Platform name
        ///</summary>
        [JsonProperty("platform")]
        public String Platform { get; set; }
        [JsonProperty("type")]
        public WallPostSourceType Type { get; set; }

        ///<summary>
        /// URL to an external site used to publish the post
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}