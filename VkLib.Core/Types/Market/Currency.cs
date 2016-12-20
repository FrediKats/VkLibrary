using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Market 
{
    public class Currency
    {
        /// <summary>
        /// Currency sign
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// Currency ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

    }
}
