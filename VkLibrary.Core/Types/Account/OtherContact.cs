using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Account
{
    public class OtherContact
    {
        /// <summary>
        /// Mutual friends count
        /// </summary>
        [JsonProperty("common_count")]
        public int? CommonCount { get; set; }

        /// <summary>
        /// Contact
        /// </summary>
        [JsonProperty("contact")]
        public string Contact { get; set; }
    }
}