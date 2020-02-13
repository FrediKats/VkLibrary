using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackGroupJoin
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("join_type")]
        public CallbackGroupJoinType JoinType { get; set; }
    }
}