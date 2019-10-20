using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
{
    public class StoriesGetVideoUploadServerResponse
    {
        ///<summary>
        /// Upload URL
        ///</summary>
        [JsonProperty("upload_url")]
        public String UploadUrl { get; set; }

        ///<summary>
        /// Users ID who can to see story.
        ///</summary>
        [JsonProperty("user_ids")]
        public int[] UserIds { get; set; }
    }
}