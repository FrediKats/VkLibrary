using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedListFull
    {
        ///<summary>
        /// Information whether reposts hiding is enabled
        ///</summary>
        [JsonProperty("no_reposts")]
        public int NoReposts { get; set; }
        [JsonProperty("source_ids")]
        public int[] SourceIds { get; set; }
    }
}