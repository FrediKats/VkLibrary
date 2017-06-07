using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Wall
{
    /// <summary>
    /// API PostResponse.
    /// </summary>
    public class PostResponse
    {
        /// <summary>
        /// Created post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }
    }
}