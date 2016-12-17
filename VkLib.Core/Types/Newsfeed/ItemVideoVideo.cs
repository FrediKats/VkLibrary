using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemVideoVideo
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<Video> Items { get; set; }

        /// <summary>
        /// Tags number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
