using Newtonsoft.Json;

namespace VkApi.Wrapper.Responses.Friends
{
    public class FriendsGetOnlineOnlineMobileResponse
    {
        [JsonProperty("online")]
        public int[] Online { get; set; }
        [JsonProperty("online_mobile")]
        public int[] OnlineMobile { get; set; }
    }
}