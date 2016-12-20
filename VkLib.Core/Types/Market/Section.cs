using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Market 
{
    public class Section
    {
        /// <summary>
        /// Section name
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// Section ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

    }
}
