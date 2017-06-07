using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;

namespace VkLibrary.Core.Responses.Groups
{
    /// <summary>
    /// API GetCatalogInfoExtendedResponse.
    /// </summary>
    public class GetCatalogInfoExtendedResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("categories")]
        public IEnumerable<GroupCategoryFull> Categories { get; set; }

        /// <summary>
        /// Information whether catalog is enabled for current user
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }
    }
}