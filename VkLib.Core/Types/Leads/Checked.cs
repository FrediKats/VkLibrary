using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Leads 
{
    public class Checked
    {
        /// <summary>
        /// Information whether user can start the lead
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// URL user should open to start the lead
        /// </summary>
        [JsonProperty("start_link")]
        public string StartLink { get; set; }

        /// <summary>
        /// Session ID
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// Reason why user can't start the lead
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

    }
}
