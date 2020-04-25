using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class WallViews
    {
        ///<summary>
        /// Count
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
    }
}