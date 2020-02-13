using System;
using Newtonsoft.Json;
using VkApi.Wrapper.Types.Audio;

namespace VkApi.Wrapper.Types.Status
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