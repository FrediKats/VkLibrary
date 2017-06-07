using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Groups;

namespace VkLibrary.Core.Responses.Groups
{
    /// <summary>
    /// API GetCatalogInfoResponse.
    /// </summary>
    public class GetCatalogInfoResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("categories")]
        public IEnumerable<GroupCategory> Categories { get; set; }

        /// <summary>
        /// Information whether catalog is enabled for current user
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }
    }
}