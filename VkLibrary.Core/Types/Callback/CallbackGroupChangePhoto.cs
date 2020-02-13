using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Types.Callback
{
    public class CallbackGroupChangePhoto
    {
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
    }
}