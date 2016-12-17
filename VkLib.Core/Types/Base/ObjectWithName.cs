using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class ObjectWithName
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Object name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
