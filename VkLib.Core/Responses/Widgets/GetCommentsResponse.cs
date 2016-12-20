using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Widgets
{
    public class GetCommentsResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("posts")]
        public IEnumerable<VkLib.Types.Widgets.WidgetComment> Posts { get; set; }

        /// <summary>
        /// Total number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
