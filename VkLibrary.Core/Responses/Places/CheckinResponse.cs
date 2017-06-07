using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Places
{
    /// <summary>
    /// API CheckinResponse.
    /// </summary>
    public class CheckinResponse
    {
        /// <summary>
        /// Checkin ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}