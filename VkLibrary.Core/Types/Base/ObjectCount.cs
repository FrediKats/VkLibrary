using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    public class ObjectCount
    {
        /// <summary>
        /// Items count
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}