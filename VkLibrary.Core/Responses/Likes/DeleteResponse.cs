using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Likes
{
    public class DeleteResponse
    {
        /// <summary>
        /// Total likes number
        /// </summary>
        [JsonProperty("likes")]
        public int? Likes { get; set; }
    }
}