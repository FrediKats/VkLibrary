using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class ItemPhoto
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photos")]
        public VkLib.Types.Newsfeed.ItemPhotoPhotos Photos { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId_ { get; set; }

    }
}
