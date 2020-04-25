using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
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