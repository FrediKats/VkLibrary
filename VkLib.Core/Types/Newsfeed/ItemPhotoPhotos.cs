using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemPhotoPhotos
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<NewsfeedPhoto> Items { get; set; }

        /// <summary>
        /// Photos number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
