using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types.Messages;

namespace VkLib.Responses.Messages
{
    public class GetLongPollHistoryResponse
    {
        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("messages")]
        public LongpollMessages Messages { get; set; }

        /// <summary>
        ///     None
        /// </summary>
        [JsonProperty("history")]
        public IEnumerable<IEnumerable<int?>> History { get; set; }
    }
}