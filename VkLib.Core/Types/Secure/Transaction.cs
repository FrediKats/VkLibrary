using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Secure 
{
    public class Transaction
    {
        /// <summary>
        /// To ID
        /// </summary>
        [JsonProperty("uid_to")]
        public int? UidTo { get; set; }

        /// <summary>
        /// Votes number
        /// </summary>
        [JsonProperty("votes")]
        public int? Votes_ { get; set; }

        /// <summary>
        /// Transaction ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Transaction date in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// From ID
        /// </summary>
        [JsonProperty("uid_from")]
        public int? UidFrom { get; set; }

    }
}
