using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Widgets 
{
    public class WidgetLikes
    {
        /// <summary>
        /// Likes number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
