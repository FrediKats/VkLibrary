using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Messages
{
    public class GetLongPollHistoryResponse
    {
        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("messages")]
        public VkLib.Types.Messages.LongpollMessages Messages { get; set; }

        /// <summary>
        /// None
        /// </summary>
        [JsonProperty("history")]
        public IEnumerable<IEnumerable<int?>> History { get; set; }

    }
}
