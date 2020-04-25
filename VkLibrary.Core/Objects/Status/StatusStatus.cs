using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class StatusStatus
    {
        [JsonProperty("audio")]
        public AudioAudio Audio { get; set; }

        ///<summary>
        /// Status text
        ///</summary>
        [JsonProperty("text")]
        public String Text { get; set; }
    }
}