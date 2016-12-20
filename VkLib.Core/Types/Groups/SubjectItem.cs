using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class SubjectItem
    {
        /// <summary>
        /// Subject title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Subject ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

    }
}
