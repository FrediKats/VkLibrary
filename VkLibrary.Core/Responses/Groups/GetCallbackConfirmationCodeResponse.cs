using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Groups
{
    public class GetCallbackConfirmationCodeResponse
    {
        /// <summary>
        /// Confirmation code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}