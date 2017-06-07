using System.Collections.Generic;
using Newtonsoft.Json;
using VkLibrary.Core.Types.Messages;

namespace VkLibrary.Core.Responses.Messages
{
    /// <summary>
    /// API GetLongPollHistoryResponse.
    /// </summary>
    public class GetLongPollHistoryResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("messages")]
        public LongpollMessages Messages { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("history")]
        public IEnumerable<IEnumerable<int?>> History { get; set; }
    }
}