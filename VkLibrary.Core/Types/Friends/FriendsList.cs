using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Friends
{
    public class FriendsList
    {
        /// <summary>
        /// List ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// List title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}