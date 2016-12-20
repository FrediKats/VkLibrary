using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class VideoAlbumFull
    {
        /// <summary>
        /// Information whether album is system
        /// </summary>
        [JsonProperty("is_system")]
        public int? IsSystem { get; set; }

        /// <summary>
        /// URL of the preview image with 320px in width
        /// </summary>
        [JsonProperty("photo_320")]
        public string Photo320 { get; set; }

        /// <summary>
        /// Total number of videos in album
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Album ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Album owner's ID
        /// </summary>
        [JsonProperty("owner_id")]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Date when the album has been updated last time in Unixtime
        /// </summary>
        [JsonProperty("updated_time")]
        public int? UpdatedTime { get; set; }

        /// <summary>
        /// Album title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// URL of the preview image with 160px in width
        /// </summary>
        [JsonProperty("photo_160")]
        public string Photo160 { get; set; }

    }
}
