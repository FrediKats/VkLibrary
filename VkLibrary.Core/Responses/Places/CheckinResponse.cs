using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Places
{
    public class CheckinResponse
    {
        /// <summary>
        /// Checkin ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}