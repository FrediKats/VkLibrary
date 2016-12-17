using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemPhotoTagPhotoTags
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<NewsfeedPhoto> Items { get; set; }

        /// <summary>
        /// Tags number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
