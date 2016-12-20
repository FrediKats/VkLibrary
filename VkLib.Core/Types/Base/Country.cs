using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class Country
    {
        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Country title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

    }
}
