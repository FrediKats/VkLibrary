using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
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
        public IEnumerable<VkLib.Types.Newsfeed.NewsfeedPhoto> Items { get; set; }

    }
}
