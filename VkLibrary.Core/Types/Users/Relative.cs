using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API Relative object.
    /// </summary>
    public class Relative
    {
        /// <summary>
        /// Relative type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Relative ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}