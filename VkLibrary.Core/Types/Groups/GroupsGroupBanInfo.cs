using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Groups
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
    }
}