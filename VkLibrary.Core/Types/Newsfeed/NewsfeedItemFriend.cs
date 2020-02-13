using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemFriend
    {
        [JsonProperty("friends")]
        public NewsfeedItemFriendFriends Friends { get; set; }
    }
}