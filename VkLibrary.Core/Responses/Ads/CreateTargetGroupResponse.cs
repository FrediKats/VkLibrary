using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Ads
{
    /// <summary>
    /// API CreateTargetGroupResponse.
    /// </summary>
    public class CreateTargetGroupResponse
    {
        /// <summary>
        /// Group ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Pixel code
        /// </summary>
        [JsonProperty("pixel")]
        public string Pixel { get; set; }
    }
}