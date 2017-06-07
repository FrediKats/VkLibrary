using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Database
{
    /// <summary>
    /// API Region object.
    /// </summary>
    public class Region
    {
        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Region title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}