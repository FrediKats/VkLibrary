using Newtonsoft.Json;

namespace VkLib.Responses.Audio
{
    public class GetUploadServerResponse
    {
        /// <summary>
        ///     URL to upload the audio
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}