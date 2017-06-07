using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Wall
{
    /// <summary>
    /// API AppPost object.
    /// </summary>
    public class AppPost
    {
        /// <summary>
        /// URL of the preview image with 604 px in width
        /// </summary>
        [JsonProperty("photo_604")]
        public string Photo604 { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// URL of the preview image with 130 px in width
        /// </summary>
        [JsonProperty("photo_130")]
        public string Photo130 { get; set; }

        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}