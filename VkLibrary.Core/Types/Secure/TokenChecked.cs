using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Secure
{
    /// <summary>
    /// API TokenChecked object.
    /// </summary>
    public class TokenChecked
    {
        /// <summary>
        /// Date when access_token will expire in Unixtime
        /// </summary>
        [JsonProperty("expire")]
        public int? Expire { get; set; }

        /// <summary>
        /// Date when access_token has been generated in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// Returns if successfully processed
        /// </summary>
        [JsonProperty("success")]
        public int? Success { get; set; }
    }
}