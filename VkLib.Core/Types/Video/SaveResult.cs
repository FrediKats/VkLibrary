using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class SaveResult
    {
        /// <summary>
        /// Video owner ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Video title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL for the video uploading
        /// </summary>
        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Video description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Video ID
        /// </summary>
        [JsonProperty("video_id")]
        public int? VideoId { get; set; }

    }
}
