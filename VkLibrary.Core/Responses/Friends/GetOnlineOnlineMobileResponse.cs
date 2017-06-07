using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Responses.Friends
{
    /// <summary>
    /// API GetOnlineOnlineMobileResponse.
    /// </summary>
    public class GetOnlineOnlineMobileResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("online")]
        public IEnumerable<int?> Online { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("online_mobile")]
        public IEnumerable<int?> OnlineMobile { get; set; }
    }
}