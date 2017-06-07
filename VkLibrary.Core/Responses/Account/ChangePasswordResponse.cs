using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Account
{
    /// <summary>
    /// API ChangePasswordResponse.
    /// </summary>
    public class ChangePasswordResponse
    {
        /// <summary>
        /// New secret
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// New token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}