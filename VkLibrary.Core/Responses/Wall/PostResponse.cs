using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Wall
{
    public class PostResponse
    {
        /// <summary>
        /// Created post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }
    }
}