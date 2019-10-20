using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersSchool
    {
        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("city")]
        public int City { get; set; }

        ///<summary>
        /// School class letter
        ///</summary>
        [JsonProperty("class")]
        public String Class { get; set; }

        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("country")]
        public int Country { get; set; }

        ///<summary>
        /// School ID
        ///</summary>
        [JsonProperty("id")]
        public String Id { get; set; }

        ///<summary>
        /// School name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// School type ID
        ///</summary>
        [JsonProperty("type")]
        public int Type { get; set; }

        ///<summary>
        /// School type name
        ///</summary>
        [JsonProperty("type_str")]
        public String TypeStr { get; set; }

        ///<summary>
        /// Year the user started to study
        ///</summary>
        [JsonProperty("year_from")]
        public int YearFrom { get; set; }

        ///<summary>
        /// Graduation year
        ///</summary>
        [JsonProperty("year_graduated")]
        public int YearGraduated { get; set; }

        ///<summary>
        /// Year the user finished to study
        ///</summary>
        [JsonProperty("year_to")]
        public int YearTo { get; set; }
    }
}