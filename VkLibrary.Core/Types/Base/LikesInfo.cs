using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    public class LikesInfo
    {
        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current user can repost
        /// </summary>
        [JsonProperty("can_publish")]
        public int? CanPublish { get; set; }

        /// <summary>
        /// Information whether current user can like the post
        /// </summary>
        [JsonProperty("can_like")]
        public int? CanLike { get; set; }

        /// <summary>
        /// Information whether current uer has liked the post
        /// </summary>
        [JsonProperty("user_likes")]
        public int? UserLikes { get; set; }
    }
}