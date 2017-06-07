using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API SexAge object.
    /// </summary>
    public class SexAge
    {
        /// <summary>
        /// Age denotation. 
        /// </summary>
        [JsonProperty("age_range")]
        public string AgeRange { get; set; }

        /// <summary>
        /// Views by female users.
        /// </summary>
        [JsonProperty("female")]
        public int? Female { get; set; }

        /// <summary>
        /// Views by male users.
        /// </summary>
        [JsonProperty("male")]
        public int? Male { get; set; }
    }
}
