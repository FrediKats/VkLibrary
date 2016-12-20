using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class NewsfeedPhoto : VkLib.Types.Photos.Photo
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public VkLib.Types.Base.ObjectCount Comments { get; set; }

        /// <summary>
        /// Information whether current user can repost the photo
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost_ { get; set; }

        /// <summary>
        /// Information whether current user can comment the photo
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.Likes Likes { get; set; }

    }
}
