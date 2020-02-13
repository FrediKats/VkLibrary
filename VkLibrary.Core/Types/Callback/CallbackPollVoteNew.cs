using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackPollVoteNew
    {
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("poll_id")]
        public int PollId { get; set; }
        [JsonProperty("option_id")]
        public int OptionId { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}