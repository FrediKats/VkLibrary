using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Photos
{
    /// <summary>
    /// API GetMarketAlbumUploadServerResponse.
    /// </summary>
    public class GetMarketAlbumUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}