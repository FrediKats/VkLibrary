using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Groups;

namespace VkLib.Responses.Groups
{
    public class GetCatalogInfoResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("categories")]
        public IEnumerable<GroupCategory> Categories { get; set; }

        /// <summary>
        ///     Information whether catalog is enabled for current user
        /// </summary>
        [JsonProperty("enabled")]
        public int? Enabled { get; set; }
    }
}