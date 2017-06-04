using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Photos
{
    public class MarketUploadResponse
    {
        /// <summary>
        /// Crop data
        /// </summary>
        [JsonProperty("crop_data")]
        public string CropData { get; set; }

        /// <summary>
        /// Upload server number
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Crop hash
        /// </summary>
        [JsonProperty("crop_hash")]
        public string CropHash { get; set; }

        /// <summary>
        /// Uploaded photo data
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// Community ID
        /// </summary>
        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

        /// <summary>
        /// Uploading hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}