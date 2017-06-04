using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
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