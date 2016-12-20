using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Docs
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
