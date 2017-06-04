using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;
using VkLibrary.Core.Types.Photos;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class NewsfeedPhoto : Photo
    {
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
        /// Information whether current user can comment the photo
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Information whether current user can repost the photo
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }
    }
}