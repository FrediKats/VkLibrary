using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class VideoVideoFull
    {
        [JsonProperty("files")]
        public VideoVideoFiles Files { get; set; }

        ///<summary>
        /// Settings for live stream
        ///</summary>
        [JsonProperty("live_settings")]
        public VideoLiveSettings LiveSettings { get; set; }

        //TODO: fix
        /////<summary>
        ///// Action button
        /////</summary>
        //[JsonProperty("action_button")]
        //public ActionLinksAction ActionButton { get; set; }
    }
}