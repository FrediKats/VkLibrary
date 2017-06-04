using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Photos
{
    public class GetMarketUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}