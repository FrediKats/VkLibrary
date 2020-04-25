using Newtonsoft.Json;
using VkApi.Wrapper.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.Responses
{
    public class PhotoCommentResponse : PhotosPhoto
    {
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        [JsonProperty("photo_owner_id")]
        public int PhotoOwnerId { get; set; }
    }
}