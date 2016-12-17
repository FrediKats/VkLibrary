using System;
using Newtonsoft.Json;

namespace VkLib.Types.Utils 
{
    public class DomainResolved
    {
        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("object_id")]
        public int? ObjectId { get; set; }

    }
}
