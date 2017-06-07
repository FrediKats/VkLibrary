using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Utils
{
    /// <summary>
    /// API LinkInfoFull object.
    /// </summary>
    public class LinkInfoFull : LinkInfo
    {
        /// <summary>
        /// Creation time in Unixtime.
        /// </summary>
        [JsonProperty("timestamp")]
        public double? Timestamp { get; set; }

        /// <summary>
        /// Views count; 
        /// </summary>
        [JsonProperty("views")]
        public int? Views { get; set; }
    }
}
