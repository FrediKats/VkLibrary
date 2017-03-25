using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class PhotoFullXtrRealOffset : Photo
    {
        /// <summary>
        /// Real position of the photo
        /// </summary>
        [JsonProperty("real_offset")]
        public int? RealOffset { get; set; }

        /// <summary>
        /// Property
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
        /// Returns if the photo is hidden above the wall
        /// </summary>
        [JsonProperty("hidden")]
        public string Hidden { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public VkLib.Types.Base.ObjectCount Reposts { get; set; }

    }
}
