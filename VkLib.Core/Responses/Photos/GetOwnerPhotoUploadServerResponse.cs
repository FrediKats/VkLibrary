using Newtonsoft.Json;

namespace VkLib.Responses.Photos
{
    public class GetOwnerPhotoUploadServerResponse
    {
        /// <summary>
        ///     URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}