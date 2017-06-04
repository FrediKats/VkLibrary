using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Places
{
    public class AddResponse
    {
        /// <summary>
        /// Place ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}