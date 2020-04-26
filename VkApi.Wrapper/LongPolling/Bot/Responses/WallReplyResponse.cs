using Newtonsoft.Json;
using VkApi.Wrapper.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    /// <summary>
    /// BotLongPoll response for <see cref="BotLongPollMessageCodes"/>
    /// </summary>
    public class WallReplyResponse : WallWallpost
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }

        /// <summary>
        /// Photo owner ID
        /// </summary>
        [JsonProperty("post_owner_id")]
        public int PostOwnerId { get; set; }
    }
}