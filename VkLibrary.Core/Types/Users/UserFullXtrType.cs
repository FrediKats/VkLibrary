using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    public class UserFullXtrType : UserFull
    {
        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}