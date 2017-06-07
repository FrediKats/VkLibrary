using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API RejectReason object.
    /// </summary>
    public class RejectReason
    {
        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("rules")]
        public IEnumerable<Rules> Rules { get; set; }
    }
}