using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemAudio : NewsfeedItemBase
    {
        [JsonProperty("audio")]
        public NewsfeedItemAudioAudio Audio { get; set; }

        ///<summary>
        /// Post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}