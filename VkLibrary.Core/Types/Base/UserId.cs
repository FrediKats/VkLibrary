using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    public class UserId
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserIdCode { get; set; }
    }
}