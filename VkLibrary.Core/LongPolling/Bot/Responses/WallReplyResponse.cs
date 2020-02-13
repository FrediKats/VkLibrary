using Newtonsoft.Json;
using VkApi.Wrapper.Types.Wall;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    public class WallReplyResponse : WallWallpost
    {
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        [JsonProperty("post_owner_id")]
        public int PostOwnerId { get; set; }
    }
}