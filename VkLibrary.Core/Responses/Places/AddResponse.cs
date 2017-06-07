using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Places
{
    /// <summary>
    /// API AddResponse.
    /// </summary>
    public class AddResponse
    {
        /// <summary>
        /// Place ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}