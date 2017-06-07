using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Database
{
    /// <summary>
    /// API School object.
    /// </summary>
    public class School
    {
        /// <summary>
        /// School ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// School title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}