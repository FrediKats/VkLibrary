using System;
using Newtonsoft.Json;

namespace VkLib.Types.Status 
{
    public class Status
    {
        /// <summary>
        /// Status text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public AudioFull Audio { get; set; }

    }
}
