using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Stats
{
    /// <summary>
    /// API Age object.
    /// </summary>
    public class Age
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Age interval
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}