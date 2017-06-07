using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Groups
{
    /// <summary>
    /// API GetCallbackConfirmationCodeResponse.
    /// </summary>
    public class GetCallbackConfirmationCodeResponse
    {
        /// <summary>
        /// Confirmation code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}