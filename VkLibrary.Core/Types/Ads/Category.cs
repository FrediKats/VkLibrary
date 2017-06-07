using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Base;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API Category object.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("subcategories")]
        public IEnumerable<ObjectWithName> Subcategories { get; set; }

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