using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    ///<summary>
    /// Timetable for one day
    ///</summary>
    public class GroupsAddressTimetableDay
    {
        ///<summary>
        /// Close time of the break in minutes
        ///</summary>
        [JsonProperty("break_close_time")]
        public int BreakCloseTime { get; set; }

        ///<summary>
        /// Start time of the break in minutes
        ///</summary>
        [JsonProperty("break_open_time")]
        public int BreakOpenTime { get; set; }

        ///<summary>
        /// Close time in minutes
        ///</summary>
        [JsonProperty("close_time")]
        public int CloseTime { get; set; }

        ///<summary>
        /// Open time in minutes
        ///</summary>
        [JsonProperty("open_time")]
        public int OpenTime { get; set; }
    }
}