using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Photos
{
    public class MessageUploadResponse
    {
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

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
    }
}