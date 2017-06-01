using Newtonsoft.Json;

namespace VkLib.Types.Base
{
    public class CommentsInfo
    {
        /// <summary>
        ///     Comments number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        ///     Information whether current user can comment the post
        /// </summary>
        [JsonProperty("can_post")]
        public int? CanPost { get; set; }
    }
}