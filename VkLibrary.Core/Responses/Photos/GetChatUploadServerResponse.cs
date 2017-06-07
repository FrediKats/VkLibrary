using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Photos
{
    /// <summary>
    /// API GetChatUploadServerResponse.
    /// </summary>
    public class GetChatUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}