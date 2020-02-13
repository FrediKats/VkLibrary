using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Polls
{
    public class PollsVotersUsers
    {
        ///<summary>
        /// Votes number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public int[] Items { get; set; }
    }
}