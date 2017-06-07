using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Stats
{
    /// <summary>
    /// API Country object.
    /// </summary>
    public class Country
    {
        /// <summary>
        /// Country code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Country name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("value")]
        public int? Value { get; set; }
    }
}