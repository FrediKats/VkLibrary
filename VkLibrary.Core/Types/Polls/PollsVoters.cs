using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Polls
{
    public class PollsVoters
    {
        ///<summary>
        /// Answer ID
        ///</summary>
        [JsonProperty("answer_id")]
        public int AnswerId { get; set; }
        [JsonProperty("users")]
        public PollsVotersUsers Users { get; set; }
    }
}