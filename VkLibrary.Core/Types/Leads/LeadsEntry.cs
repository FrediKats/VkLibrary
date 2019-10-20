using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class LeadsEntry
    {
        ///<summary>
        /// Application ID
        ///</summary>
        [JsonProperty("aid")]
        public int Aid { get; set; }

        ///<summary>
        /// Comment text
        ///</summary>
        [JsonProperty("comment")]
        public String Comment { get; set; }

        ///<summary>
        /// Date when the action has been started in Unixtime
        ///</summary>
        [JsonProperty("date")]
        public int Date { get; set; }

        ///<summary>
        /// Session string ID
        ///</summary>
        [JsonProperty("sid")]
        public String Sid { get; set; }

        ///<summary>
        /// Start date in Unixtime (for status=2)
        ///</summary>
        [JsonProperty("start_date")]
        public int StartDate { get; set; }

        ///<summary>
        /// Action type
        ///</summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        ///<summary>
        /// Information whether test mode is enabled
        ///</summary>
        [JsonProperty("test_mode")]
        public int TestMode { get; set; }

        ///<summary>
        /// User ID
        ///</summary>
        [JsonProperty("uid")]
        public int Uid { get; set; }
    }
}