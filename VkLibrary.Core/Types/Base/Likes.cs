using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API Likes object.
    /// </summary>
    public class Likes
    {
        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current user likes the photo
        /// </summary>
        [JsonProperty("user_likes")]
        public int? UserLikes { get; set; }
    }
}