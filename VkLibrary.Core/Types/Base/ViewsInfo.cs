using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Base
{
    /// <summary>
    /// API ViewsInfo object.
    /// </summary>
    public class ViewsInfo
    {
        /// <summary>
        /// Views count.
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}