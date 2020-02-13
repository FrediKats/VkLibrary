using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersExports
    {
        [JsonProperty("facebook")]
        public int Facebook { get; set; }
        [JsonProperty("livejournal")]
        public int Livejournal { get; set; }
        [JsonProperty("twitter")]
        public int Twitter { get; set; }
    }
}