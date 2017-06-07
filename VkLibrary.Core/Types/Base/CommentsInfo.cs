using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API CommentsInfo object.
    /// </summary>
    public class CommentsInfo
    {
        /// <summary>
        /// Comments number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Information whether current user can comment the post
        /// </summary>
        [JsonProperty("can_post")]
        public int? CanPost { get; set; }
    }
}