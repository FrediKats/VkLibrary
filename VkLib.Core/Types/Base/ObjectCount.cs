using Newtonsoft.Json;

namespace VkLib.Types.Base
{
    public class ObjectCount
    {
        /// <summary>
        ///     Items count
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}