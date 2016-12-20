using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Database 
{
    public class School
    {
        /// <summary>
        /// School ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// School title
        /// </summary>
        [JsonProperty("title")]
        public string Title_ { get; set; }

    }
}
