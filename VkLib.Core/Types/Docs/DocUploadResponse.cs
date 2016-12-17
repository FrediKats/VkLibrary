using System;
using Newtonsoft.Json;

namespace VkLib.Types.Docs 
{
    public class DocUploadResponse
    {
        /// <summary>
        /// Uploaded file data
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }

    }
}
