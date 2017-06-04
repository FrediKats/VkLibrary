using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;

namespace VkLibrary.Core.Types.Video
{
    public class VideoFull : Video
    {
        /// <summary>
        /// Information whether current user can comment the video
        /// </summary>
        [JsonProperty("can_comment")]
        public int? CanComment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("privacy_comment")]
        public IEnumerable<string> PrivacyComment { get; set; }

        /// <summary>
        /// Information whether the video is repeated
        /// </summary>
        [JsonProperty("repeat")]
        public int? Repeat { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("privacy_view")]
        public IEnumerable<string> PrivacyView { get; set; }

        /// <summary>
        /// Information whether current user can comment the video
        /// </summary>
        [JsonProperty("can_repost")]
        public int? CanRepost { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("likes")]
        public Likes Likes { get; set; }
    }
}