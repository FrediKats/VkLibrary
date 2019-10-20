using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseUploadServer
    {
        ///<summary>
        /// Upload URL
        ///</summary>
        [JsonProperty("upload_url")]
        public String UploadUrl { get; set; }
    }
}