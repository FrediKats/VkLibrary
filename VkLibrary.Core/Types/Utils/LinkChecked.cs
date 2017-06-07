using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API LinkChecked object.
    /// </summary>
    public class LinkChecked
    {
        /// <summary>
        /// Link status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}