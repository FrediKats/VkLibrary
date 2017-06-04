using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Wall
{
    public class WallpostAttached : WallpostFull
    {
        /// <summary>
        /// Post addresse
        /// </summary>
        [JsonProperty("to_id")]
        public int? ToId { get; set; }

        /// <summary>
        /// Repost comment
        /// </summary>
        [JsonProperty("copy_text")]
        public string CopyText { get; set; }

        /// <summary>
        /// Source post owner's ID
        /// </summary>
        [JsonProperty("copy_owner_id")]
        public int? CopyOwnerId { get; set; }

        /// <summary>
        /// Source post ID
        /// </summary>
        [JsonProperty("copy_post_id")]
        public int? CopyPostId { get; set; }
    }
}