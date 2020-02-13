using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackPhotoCommentDelete
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }
    }
}