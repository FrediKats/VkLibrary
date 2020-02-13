using Newtonsoft.Json;
using VkApi.Wrapper.Types.Base;

namespace VkApi.Wrapper.Types.Newsfeed
{
    public class NewsfeedItemFriendFriends
    {
        ///<summary>
        /// Number of friends has been added
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public BaseUserId[] Items { get; set; }
    }
}