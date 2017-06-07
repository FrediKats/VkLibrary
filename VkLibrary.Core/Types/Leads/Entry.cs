using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Leads
{
    /// <summary>
    /// API Entry object.
    /// </summary>
    public class Entry
    {
        /// <summary>
        /// Date when the action has been started in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date { get; set; }

        /// <summary>
        /// Action type
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("aid")]
        public int? Aid { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public int? TestMode { get; set; }

        /// <summary>
        /// Start date in Unixtime (for status=2)
        /// </summary>
        [JsonProperty("start_date")]
        public int? StartDate { get; set; }

        /// <summary>
        /// Session string ID
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }
    }
}