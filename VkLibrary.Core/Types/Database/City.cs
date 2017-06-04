using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;

namespace VkLibrary.Core.Types.Database
{
    public class City : Object
    {
        /// <summary>
        /// Region title
        /// </summary>
        [JsonProperty("region")]
        public string Region { get; set; }

        /// <summary>
        /// Area title
        /// </summary>
        [JsonProperty("area")]
        public string Area { get; set; }

        /// <summary>
        /// Information whether the city is included in important cities list
        /// </summary>
        [JsonProperty("important")]
        public int? Important { get; set; }
    }
}