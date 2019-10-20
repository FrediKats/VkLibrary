using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class VideoVideoFiles
    {
        ///<summary>
        /// URL of the external player
        ///</summary>
        [JsonProperty("external")]
        public String External { get; set; }

        ///<summary>
        /// URL of the mpeg4 file with 1080p quality
        ///</summary>
        [JsonProperty("mp4_1080")]
        public String Mp41080 { get; set; }

        ///<summary>
        /// URL of the mpeg4 file with 240p quality
        ///</summary>
        [JsonProperty("mp4_240")]
        public String Mp4240 { get; set; }

        ///<summary>
        /// URL of the mpeg4 file with 360p quality
        ///</summary>
        [JsonProperty("mp4_360")]
        public String Mp4360 { get; set; }

        ///<summary>
        /// URL of the mpeg4 file with 480p quality
        ///</summary>
        [JsonProperty("mp4_480")]
        public String Mp4480 { get; set; }

        ///<summary>
        /// URL of the mpeg4 file with 720p quality
        ///</summary>
        [JsonProperty("mp4_720")]
        public String Mp4720 { get; set; }
    }
}