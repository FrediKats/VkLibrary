using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Friends
{
    public class FriendsUserXtrLists
    {
        [JsonProperty("lists")]
        public int[] Lists { get; set; }
    }
}