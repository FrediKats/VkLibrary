using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class PhotoFull : Photo
    {
        /// <summary>
        /// Information whether current user can comment the photo
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("comments")]
        public VkLib.Types.Base.ObjectCount Comments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public VkLib.Types.Base.Likes Likes { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("tags")]
        public VkLib.Types.Base.ObjectCount Tags { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public VkLib.Types.Base.ObjectCount Reposts { get; set; }

    }
}
