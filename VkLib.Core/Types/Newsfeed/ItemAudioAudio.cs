using System;
using Newtonsoft.Json;

namespace VkLib.Types.Newsfeed 
{
    public class ItemAudioAudio
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<AudioFull> Items { get; set; }

        /// <summary>
        /// Audios number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
