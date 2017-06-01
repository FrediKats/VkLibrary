using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed
{
    public class ItemVideoVideo
    {
        /// <summary>
        ///     Tags number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<Video.Video> Items { get; set; }
    }
}