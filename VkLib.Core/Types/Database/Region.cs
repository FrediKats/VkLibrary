using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Database 
{
    public class Region
    {
        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Region title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

    }
}
