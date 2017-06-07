using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Newsfeed
{
    /// <summary>
    /// API ItemFriend object.
    /// </summary>
    public class ItemFriend
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("friends")]
        public object Friends { get; set; }
    }
}