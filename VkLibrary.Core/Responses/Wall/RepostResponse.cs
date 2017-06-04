using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Wall
{
    public class RepostResponse
    {
        /// <summary>
        /// Created post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("success")]
        public int Success { get; set; }

        /// <summary>
        /// Reposts number
        /// </summary>
        [JsonProperty("likes_count")]
        public int? LikesCount { get; set; }

        /// <summary>
        /// Reposts number
        /// </summary>
        [JsonProperty("reposts_count")]
        public int? RepostsCount { get; set; }
    }
}