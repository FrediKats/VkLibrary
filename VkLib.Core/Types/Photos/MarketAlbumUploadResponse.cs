using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class MarketAlbumUploadResponse
    {
        /// <summary>
        /// Uploading hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

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
        /// Community ID
        /// </summary>
        [JsonProperty("gid")]
        public int? Gid { get; set; }

    }
}
