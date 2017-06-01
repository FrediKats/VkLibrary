using Newtonsoft.Json;

namespace VkLib.Responses.Places
{
    public class AddResponse
    {
        /// <summary>
        ///     Place ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}