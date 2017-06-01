using Newtonsoft.Json;
using VkLib.Types.Base;

namespace VkLib.Types.Photos
{
    public class PhotoFullXtrRealOffset : Photo
    {
        /// <summary>
        ///     Real position of the photo
        /// </summary>
        [JsonProperty("real_offset")]
        public int? RealOffset { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("comments")]
        public ObjectCount Comments { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("tags")]
        public ObjectCount Tags { get; set; }

        /// <summary>
        ///     Returns if the photo is hidden above the wall
        /// </summary>
        [JsonProperty("hidden")]
        public string Hidden { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("reposts")]
        public ObjectCount Reposts { get; set; }
    }
}