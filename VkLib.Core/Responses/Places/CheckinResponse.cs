using Newtonsoft.Json;

namespace VkLib.Responses.Places
{
    public class CheckinResponse
    {
        /// <summary>
        ///     Checkin ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}