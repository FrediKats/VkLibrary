using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class ItemPhotoTag
    {
        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("photo_tags")]
        public VkLib.Types.Newsfeed.ItemPhotoTagPhotoTags PhotoTags { get; set; }

    }
}
