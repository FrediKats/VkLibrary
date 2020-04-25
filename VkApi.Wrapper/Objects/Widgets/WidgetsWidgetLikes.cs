using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WidgetsWidgetLikes
    {
        ///<summary>
        /// Likes number
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}