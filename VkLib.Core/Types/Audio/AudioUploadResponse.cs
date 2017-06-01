using Newtonsoft.Json;

namespace VkLib.Types.Audio
{
    public class AudioUploadResponse
    {
        /// <summary>
        ///     Uploaded aduio data
        /// </summary>
        [JsonProperty("audio")]
        public string Audio { get; set; }

        /// <summary>
        ///     Uploading hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        ///     Redirect URL
        /// </summary>
        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        /// <summary>
        ///     Upload server number
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }
    }
}