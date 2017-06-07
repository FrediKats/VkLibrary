using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Database
{
    /// <summary>
    /// API Street object.
    /// </summary>
    public class Street
    {
        /// <summary>
        /// Street ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Street title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}