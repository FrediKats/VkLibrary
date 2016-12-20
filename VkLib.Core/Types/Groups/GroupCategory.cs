using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class GroupCategory
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("subcategories")]
        public IEnumerable<VkLib.Types.Base.ObjectWithName> Subcategories { get; set; }

        /// <summary>
        /// Category ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
