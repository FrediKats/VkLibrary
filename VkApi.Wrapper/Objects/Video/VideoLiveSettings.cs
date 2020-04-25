using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Video live settings
    ///</summary>
    public class VideoLiveSettings
    {
        ///<summary>
        /// If user car rewind live or not
        ///</summary>
        [JsonProperty("can_rewind")]
        public int CanRewind { get; set; }

        ///<summary>
        /// If live is endless or not
        ///</summary>
        [JsonProperty("is_endless")]
        public int IsEndless { get; set; }

        ///<summary>
        /// Max possible time for rewind
        ///</summary>
        [JsonProperty("max_duration")]
        public int MaxDuration { get; set; }
    }
}