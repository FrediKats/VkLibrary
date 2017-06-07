using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API ObjectCount object.
    /// </summary>
    public class ObjectCount
    {
        /// <summary>
        /// Items count
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}