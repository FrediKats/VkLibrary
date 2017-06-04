using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;

namespace VkLibrary.Core.Types.Photos
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
        public ObjectCount Comments { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public Likes Likes { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("tags")]
        public ObjectCount Tags { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("reposts")]
        public ObjectCount Reposts { get; set; }
    }
}