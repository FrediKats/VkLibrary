using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Utils 
{
    public class DomainResolved
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("object_id")]
        public int? ObjectId { get; set; }

        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
