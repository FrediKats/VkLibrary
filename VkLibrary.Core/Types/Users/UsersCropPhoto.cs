using Newtonsoft.Json;
using VkApi.Wrapper.Types.Photos;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersCropPhoto
    {
        [JsonProperty("crop")]
        public UsersCropPhotoCrop Crop { get; set; }
        [JsonProperty("photo")]
        public PhotosPhoto Photo { get; set; }
        [JsonProperty("rect")]
        public UsersCropPhotoRect Rect { get; set; }
    }
}