using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Docs
{
    public class GetWallUploadServerResponse
    {
        /// <summary>
        /// Upload URL
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
    }
}