using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Photos
{
    /// <summary>
    /// API PhotoUploadResponse object.
    /// </summary>
    public class PhotoUploadResponse
    {
        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("aid")]
        public int? Aid { get; set; }

        /// <summary>
        /// Upload server number
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Uploading hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Uploaded photos data
        /// </summary>
        [JsonProperty("photos_list")]
        public string PhotosList { get; set; }
    }
}