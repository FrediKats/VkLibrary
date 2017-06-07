using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Stats
{
    /// <summary>
    /// API SexAge object.
    /// </summary>
    public class SexAge
    {
        /// <summary>
        /// Visitors number
        /// </summary>
        [JsonProperty("visitors")]
        public int? Visitors { get; set; }

        /// <summary>
        /// Sex and age interval
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}