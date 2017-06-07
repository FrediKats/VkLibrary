using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Places
{
    /// <summary>
    /// API Types object.
    /// </summary>
    public class Types
    {
        /// <summary>
        /// URL of the place's icon
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Place type ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Place type title
        /// </summary>
        [JsonProperty("title")]
        public int? Title { get; set; }
    }
}