using Newtonsoft.Json;
using VkLibrary.Core.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.LongPollResponse
{
    public class WallReplyResponse : WallWallpost
    {
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        [JsonProperty("post_owner_id")]
        public int PostOwnerId { get; set; }
    }
}