using Newtonsoft.Json;

namespace VkLib.Responses.Groups
{
    public class GetCallbackConfirmationCodeResponse
    {
        /// <summary>
        ///     Confirmation code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
    }
}