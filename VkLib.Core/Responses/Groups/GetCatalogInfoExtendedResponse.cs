using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Groups
{
    public class GetCatalogInfoExtendedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("categories")]
        public IEnumerable<VkLib.Types.Groups.GroupCategoryFull> Categories { get; set; }

        /// <summary>
        /// Information whether catalog is enabled for current user
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }

    }
}
