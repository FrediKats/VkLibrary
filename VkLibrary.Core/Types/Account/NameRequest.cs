using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Account
{
    /// <summary>
    /// API NameRequest object.
    /// </summary>
    public class NameRequest
    {
        /// <summary>
        /// Last name in request
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// First name in request
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Request status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Request ID needed to cancel the request
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }
    }
}