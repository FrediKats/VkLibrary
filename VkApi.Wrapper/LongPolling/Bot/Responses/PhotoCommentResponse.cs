using Newtonsoft.Json;
using VkApi.Wrapper.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    /// <summary>
    /// BotLongPoll response for <see cref="BotLongPollMessageCodes"/>
    /// </summary>
    public class PhotoCommentResponse : PhotosPhoto
    {
        /// <summary>
        /// Photo ID
        /// </summary>
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        /// <summary>
        /// Photo owner ID
        /// </summary>
        [JsonProperty("photo_owner_id")]
        public int PhotoOwnerId { get; set; }
    }
}