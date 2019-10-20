using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    ///<summary>
    /// Timetable for a week
    ///</summary>
    public class GroupsAddressTimetable
    {
        ///<summary>
        /// Timetable for friday
        ///</summary>
        [JsonProperty("fri")]
        public GroupsAddressTimetableDay Fri { get; set; }

        ///<summary>
        /// Timetable for monday
        ///</summary>
        [JsonProperty("mon")]
        public GroupsAddressTimetableDay Mon { get; set; }

        ///<summary>
        /// Timetable for saturday
        ///</summary>
        [JsonProperty("sat")]
        public GroupsAddressTimetableDay Sat { get; set; }

        ///<summary>
        /// Timetable for sunday
        ///</summary>
        [JsonProperty("sun")]
        public GroupsAddressTimetableDay Sun { get; set; }

        ///<summary>
        /// Timetable for thursday
        ///</summary>
        [JsonProperty("thu")]
        public GroupsAddressTimetableDay Thu { get; set; }

        ///<summary>
        /// Timetable for tuesday
        ///</summary>
        [JsonProperty("tue")]
        public GroupsAddressTimetableDay Tue { get; set; }

        ///<summary>
        /// Timetable for wednesday
        ///</summary>
        [JsonProperty("wed")]
        public GroupsAddressTimetableDay Wed { get; set; }
    }
}