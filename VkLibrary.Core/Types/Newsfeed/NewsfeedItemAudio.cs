using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemAudio
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