using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Widgets;

namespace VkLib.Responses.Widgets
{
    public class GetPagesResponse
    {
        /// <summary>
        ///     Total number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("pages")]
        public IEnumerable<WidgetPage> Pages { get; set; }
    }
}