using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Photos 
{
    public class PhotoUploadResponse
    {
        /// <summary>
        /// Uploaded photos data
        /// </summary>
        [JsonProperty("photos_list")]
        public string PhotosList { get; set; }

        /// <summary>
        /// Uploading hash
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Upload server number
        /// </summary>
        [JsonProperty("server")]
        public int? Server { get; set; }

        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("aid")]
        public int? Aid { get; set; }

    }
}
