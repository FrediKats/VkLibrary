using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class Occupation
    {
        /// <summary>
        /// Name of occupation
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// Type of occupation
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// ID of school, university, company group
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

    }
}
