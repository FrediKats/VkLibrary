using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Groups;

namespace VkLib.Responses.Groups
{
    public class GetCatalogInfoExtendedResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("categories")]
        public IEnumerable<GroupCategoryFull> Categories { get; set; }

        /// <summary>
        ///     Information whether catalog is enabled for current user
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }
    }
}