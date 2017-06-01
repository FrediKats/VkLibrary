using Newtonsoft.Json;
using VkLib.Types.Wall;

namespace VkLib.Types.Newsfeed
{
    public class ItemWallpost : WallpostFull
    {
        /// <summary>
        ///     Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

        /// <summary>
        ///     Post's Author
        /// </summary>
        [JsonProperty("source_id")]
        public int? SourceId { get; set; }
    }
}