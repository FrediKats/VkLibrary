using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Leads
{
    public class LeadsChecked
    {
        ///<summary>
        /// Reason why user can't start the lead
        ///</summary>
        [JsonProperty("reason")]
        public String Reason { get; set; }
        [JsonProperty("result")]
        public LeadsCheckedResult Result { get; set; }

        ///<summary>
        /// Session ID
        ///</summary>
        [JsonProperty("sid")]
        public String Sid { get; set; }

        ///<summary>
        /// URL user should open to start the lead
        ///</summary>
        [JsonProperty("start_link")]
        public String StartLink { get; set; }
    }
}