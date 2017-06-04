using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Auth
{
    public class RestoreResponse
    {
        /// <summary>
        /// 1 if success
        /// </summary>
        [JsonProperty("success")]
        public int? Success { get; set; }

        /// <summary>
        /// Parameter needed to grant access by code
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}