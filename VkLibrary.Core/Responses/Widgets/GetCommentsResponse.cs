using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Widgets;

namespace VkLibrary.Core.Responses.Widgets
{
    public class GetCommentsResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("posts")]
        public IEnumerable<WidgetComment> Posts { get; set; }

        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}