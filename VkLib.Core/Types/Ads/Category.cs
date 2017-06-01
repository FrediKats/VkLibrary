using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Base;

namespace VkLib.Types.Ads
{
    public class Category
    {
        /// <summary>
        ///     Property
        /// </summary>
        [JsonProperty("subcategories")]
        public IEnumerable<ObjectWithName> Subcategories { get; set; }

        /// <summary>
        ///     Category ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     Category name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}