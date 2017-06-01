using Newtonsoft.Json;

namespace VkLib.Responses.Photos
{
    public class GetChatUploadServerResponse
    {
        /// <summary>
        ///     URL to upload the photo
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}