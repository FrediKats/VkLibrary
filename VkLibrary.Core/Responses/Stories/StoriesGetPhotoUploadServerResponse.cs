using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Stories
{
    public class StoriesGetPhotoUploadServerResponse
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