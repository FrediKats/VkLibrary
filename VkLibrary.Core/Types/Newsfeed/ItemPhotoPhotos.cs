using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemPhotoPhotos
    {
        /// <summary>
        /// Photos number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<NewsfeedPhoto> Items { get; set; }
    }
}