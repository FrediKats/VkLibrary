using Newtonsoft.Json;

namespace VkLib.Types.Users
{
    public class UserXtrType : User
    {
        /// <summary>
        ///     Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}