using Newtonsoft.Json;

namespace VkLib.Types.Base
{
    public class Country
    {
        /// <summary>
        ///     Country ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Country title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}