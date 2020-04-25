using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsGroupBanInfo
    {
        ///<summary>
        /// Ban comment
        ///</summary>
        [JsonProperty("comment")]
        public String Comment { get; set; }

        ///<summary>
        /// End date of ban in Unixtime
        ///</summary>
        [JsonProperty("end_date")]
        public int EndDate { get; set; }
        [JsonProperty("reason")]
        public GroupsBanInfoReason Reason { get; set; }
    }
}