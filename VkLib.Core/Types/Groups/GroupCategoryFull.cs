using System;
using Newtonsoft.Json;

namespace VkLib.Types.Groups 
{
    public class GroupCategoryFull
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("subcategories")]
        public IEnumerable<GroupCategory> Subcategories { get; set; }

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

        /// <summary>
        /// Pages number
        /// </summary>
        [JsonProperty("page_count")]
        public int? PageCount { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("page_previews")]
        public IEnumerable<Group> PagePreviews { get; set; }

    }
}
