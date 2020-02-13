using Newtonsoft.Json;
using VkApi.Wrapper.Types.Audio;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemAudioAudio
    {
        ///<summary>
        /// Audios number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public AudioAudio[] Items { get; set; }
    }
}