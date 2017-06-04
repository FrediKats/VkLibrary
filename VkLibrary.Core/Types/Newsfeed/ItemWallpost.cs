using Newtonsoft.Json;
using VkLibrary.Core.Types.Wall;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemWallpost : WallpostFull
    {
        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        /// Post's Author
        /// </summary>
        [JsonProperty("source_id")]
        public int? SourceId { get; set; }
    }
}