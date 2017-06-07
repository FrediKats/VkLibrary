using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API RequestParam object.
    /// </summary>
    public class RequestParam
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Parameter value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}