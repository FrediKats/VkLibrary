using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Audio;

namespace VkLib.Types.Newsfeed
{
    public class ItemAudioAudio
    {
        /// <summary>
        ///     Audios number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<AudioFull> Items { get; set; }
    }
}