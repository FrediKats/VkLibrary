using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class WallUploadResponse
    {
        /// <summary>
        /// Uploaded photo data
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// Upload server number
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Uploading hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

    }
}
