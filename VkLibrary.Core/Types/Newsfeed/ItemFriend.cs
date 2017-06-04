using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    public class ItemFriend
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friends")]
        public object Friends { get; set; }
    }
}