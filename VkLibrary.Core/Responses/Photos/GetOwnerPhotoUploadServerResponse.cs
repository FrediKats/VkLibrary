using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Photos
{
    /// <summary>
    /// API GetOwnerPhotoUploadServerResponse.
    /// </summary>
    public class GetOwnerPhotoUploadServerResponse
    {
        /// <summary>
        /// URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}