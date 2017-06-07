using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Audio
{
    /// <summary>
    /// API GetUploadServerResponse.
    /// </summary>
    public class GetUploadServerResponse
    {
        /// <summary>
        /// URL to upload the audio
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}