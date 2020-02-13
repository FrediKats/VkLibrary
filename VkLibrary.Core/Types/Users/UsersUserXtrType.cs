using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersUserXtrType
    {
        [JsonProperty("type")]
        public UsersUserType Type { get; set; }
    }
}