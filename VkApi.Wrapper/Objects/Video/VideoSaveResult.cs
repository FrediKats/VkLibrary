using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class VideoSaveResult
    {
        ///<summary>
        /// Video access key
        ///</summary>
        [JsonProperty("access_key")]
        public String AccessKey { get; set; }

        ///<summary>
        /// Video description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }

        ///<summary>
        /// Video owner ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Video title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// URL for the video uploading
        ///</summary>
        [JsonProperty("upload_url")]
        public String UploadUrl { get; set; }

        ///<summary>
        /// Video ID
        ///</summary>
        [JsonProperty("video_id")]
        public int VideoId { get; set; }
    }
}