using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Status 
{
    public class Status
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public VkLib.Types.Audio.AudioFull Audio_ { get; set; }

        /// <summary>
        /// Status text
        /// </summary>
        [JsonProperty("text")]
        public string Text_ { get; set; }

    }
}
