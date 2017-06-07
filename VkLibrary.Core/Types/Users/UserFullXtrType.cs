using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API UserFullXtrType object.
    /// </summary>
    public class UserFullXtrType : UserFull
    {
        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}