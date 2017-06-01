using Newtonsoft.Json;

namespace VkLib.Types.Groups
{
    public class MemberRole
    {
        /// <summary>
        ///     User ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     User's credentials as community admin
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}