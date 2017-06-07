using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Auth
{
    /// <summary>
    /// API ConfirmResponse.
    /// </summary>
    public class ConfirmResponse
    {
        /// <summary>
        /// 1 if success
        /// </summary>
        [JsonProperty("success")]
        public int? Success { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }
    }
}