using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Docs
{
    public class DocsDocUploadResponse
    {
        ///<summary>
        /// Uploaded file data
        ///</summary>
        [JsonProperty("file")]
        public String File { get; set; }
    }
}