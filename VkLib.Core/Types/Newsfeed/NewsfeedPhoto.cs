using Newtonsoft.Json;
using VkLib.Types.Base;
using VkLib.Types.Photos;

namespace VkLib.Types.Newsfeed
{
    public class NewsfeedPhoto : Photo
    {
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
        ///     Information whether current user can comment the photo
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        ///     Information whether current user can repost the photo
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }
    }
}