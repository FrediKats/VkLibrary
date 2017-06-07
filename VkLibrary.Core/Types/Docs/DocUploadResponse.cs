using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Docs
{
    /// <summary>
    /// API DocUploadResponse object.
    /// </summary>
    public class DocUploadResponse
    {
        /// <summary>
        /// Uploaded file data
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }
    }
}