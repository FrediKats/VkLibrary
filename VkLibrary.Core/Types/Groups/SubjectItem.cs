using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Groups
{
    /// <summary>
    /// API SubjectItem object.
    /// </summary>
    public class SubjectItem
    {
        /// <summary>
        /// Subject ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Subject title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}