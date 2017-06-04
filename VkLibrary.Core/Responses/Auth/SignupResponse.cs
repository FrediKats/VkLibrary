using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Auth
{
    public class SignupResponse
    {
        /// <summary>
        /// Parameter to retry
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}