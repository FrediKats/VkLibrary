using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Docs
{
    /// <summary>
    /// API DocTypes object.
    /// </summary>
    public class DocTypes
    {
        /// <summary>
        /// Number of docs
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Doc type ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Doc type title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}