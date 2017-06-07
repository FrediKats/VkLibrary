using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Widgets;

namespace VkLibrary.Core.Responses.Widgets
{
    /// <summary>
    /// API GetPagesResponse.
    /// </summary>
    public class GetPagesResponse
    {
        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("pages")]
        public IEnumerable<WidgetPage> Pages { get; set; }
    }
}