using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Likes
{
    /// <summary>
    /// API DeleteResponse.
    /// </summary>
    public class DeleteResponse
    {
        /// <summary>
        /// Total likes number
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }
    }
}