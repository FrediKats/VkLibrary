using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Database
{
    /// <summary>
    /// API University object.
    /// </summary>
    public class University
    {
        /// <summary>
        /// University ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// University title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}