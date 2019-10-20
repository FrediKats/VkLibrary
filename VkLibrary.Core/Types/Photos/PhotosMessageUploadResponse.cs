using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class PhotosMessageUploadResponse
    {
        ///<summary>
        /// Uploading hash
        ///</summary>
        [JsonProperty("hash")]
        public String Hash { get; set; }

        ///<summary>
        /// Uploaded photo data
        ///</summary>
        [JsonProperty("photo")]
        public String Photo { get; set; }

        ///<summary>
        /// Upload server number
        ///</summary>
        [JsonProperty("server")]
        public int Server { get; set; }
    }
}