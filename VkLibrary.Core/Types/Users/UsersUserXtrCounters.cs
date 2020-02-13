using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersUserXtrCounters
    {
        [JsonProperty("counters")]
        public UsersUserCounters Counters { get; set; }
    }
}