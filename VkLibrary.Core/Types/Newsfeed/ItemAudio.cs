using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemAudio
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("audio")]
        public ItemAudioAudio Audio { get; set; }

        /// <summary>
        /// Post ID
        /// </summary>
        [JsonProperty("post_id")]
        public int? PostId { get; set; }
    }
}