using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class ObjectCount
    {
        /// <summary>
        /// Items count
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

    }
}
