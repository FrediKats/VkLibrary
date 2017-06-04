using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Groups
{
    public class SetCallbackServerResponse
    {
        /// <summary>
        /// State code
        /// </summary>
        [JsonProperty("state_code")]
        public int? StateCode { get; set; }

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}