using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Groups 
{
    public class GroupCategoryFull
    {
        /// <summary>
        /// Pages number
        /// </summary>
        [JsonProperty("page_count")]
        public int? PageCount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("subcategories")]
        public IEnumerable<VkLib.Types.Groups.GroupCategory> Subcategories { get; set; }

        /// <summary>
        /// Category ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("page_previews")]
        public IEnumerable<VkLib.Types.Groups.Group> PagePreviews { get; set; }

        /// <summary>
        /// Category name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
