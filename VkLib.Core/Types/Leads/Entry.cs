using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Leads 
{
    public class Entry
    {
        /// <summary>
        /// User ID
        /// </summary>
        [JsonProperty("uid")]
        public int? Uid_ { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public int? TestMode { get; set; }

        /// <summary>
        /// Comment text
        /// </summary>
        [JsonProperty("comment")]
        public string Comment_ { get; set; }

        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("aid")]
        public int? Aid_ { get; set; }

        /// <summary>
        /// Session string ID
        /// </summary>
        [JsonProperty("sid")]
        public string Sid_ { get; set; }

        /// <summary>
        /// Start date in Unixtime (for status=2)
        /// </summary>
        [JsonProperty("start_date")]
        public int? StartDate { get; set; }

        /// <summary>
        /// Date when the action has been started in Unixtime
        /// </summary>
        [JsonProperty("date")]
        public int? Date_ { get; set; }

        /// <summary>
        /// Action type
        /// </summary>
        [JsonProperty("status")]
        public int? Status_ { get; set; }

    }
}
