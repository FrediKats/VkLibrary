using Newtonsoft.Json;

namespace VkLib.Responses.Auth
{
    public class ConfirmResponse
    {
        /// <summary>
        ///     1 if success
        /// </summary>
        [JsonProperty("success")]
        public int? Success { get; set; }

        /// <summary>
        ///     User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }
    }
}