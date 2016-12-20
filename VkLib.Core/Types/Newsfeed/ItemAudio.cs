using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Newsfeed 
{
    public class ItemAudio
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public VkLib.Types.Newsfeed.ItemAudioAudio Audio { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }

    }
}
