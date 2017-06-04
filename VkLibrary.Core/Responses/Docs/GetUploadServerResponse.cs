using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Docs
{
    public class GetUploadServerResponse
    {
        /// <summary>
        /// Upload URL
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}