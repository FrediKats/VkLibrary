using Newtonsoft.Json;

namespace VkLib.Types.Users
{
    public class UserFullXtrType : UserFull
    {
        /// <summary>
        ///     Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}