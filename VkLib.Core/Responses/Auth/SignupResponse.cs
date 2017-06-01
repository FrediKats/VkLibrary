using Newtonsoft.Json;

namespace VkLib.Responses.Auth
{
    public class SignupResponse
    {
        /// <summary>
        ///     Parameter to retry
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}