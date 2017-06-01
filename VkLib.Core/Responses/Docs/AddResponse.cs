using Newtonsoft.Json;

namespace VkLib.Responses.Docs
{
    public class AddResponse
    {
        /// <summary>
        ///     Doc ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}