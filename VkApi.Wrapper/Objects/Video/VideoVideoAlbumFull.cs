using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class VideoVideoAlbumFull
    {
        ///<summary>
        /// Total number of videos in album
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        ///<summary>
        /// Album ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Album cover image in different sizes
        ///</summary>
        [JsonProperty("image")]
        public VideoVideoImage[] Image { get; set; }

        ///<summary>
        /// Need blur album thumb or not
        ///</summary>
        [JsonProperty("image_blur")]
        public BasePropertyExists ImageBlur { get; set; }

        ///<summary>
        /// Information whether album is system
        ///</summary>
        [JsonProperty("is_system")]
        public BasePropertyExists IsSystem { get; set; }

        ///<summary>
        /// Album owner's ID
        ///</summary>
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        ///<summary>
        /// Album title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }

        ///<summary>
        /// Date when the album has been updated last time in Unixtime
        ///</summary>
        [JsonProperty("updated_time")]
        public int UpdatedTime { get; set; }
    }
}