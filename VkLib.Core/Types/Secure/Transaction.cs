using Newtonsoft.Json;

namespace VkLib.Types.Secure
{
    public class Transaction
    {
        /// <summary>
        ///     From ID
        /// </summary>
        [JsonProperty("uid_from")]
        public int? UidFrom { get; set; }

        /// <summary>
        ///     Transaction date in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        ///     Votes number
        /// </summary>
        [JsonProperty("votes")]
        public int? Votes { get; set; }

        /// <summary>
        ///     Transaction ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        ///     To ID
        /// </summary>
        [JsonProperty("uid_to")]
        public int? UidTo { get; set; }
    }
}