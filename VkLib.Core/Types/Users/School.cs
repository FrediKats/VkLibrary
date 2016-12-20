using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class School
    {
        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country")]
        public int? Country_ { get; set; }

        /// <summary>
        /// School name
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// School type ID
        /// </summary>
        [JsonProperty("type")]
        public int? Type_ { get; set; }

        /// <summary>
        /// School ID
        /// </summary>
        [JsonProperty("id")]
        public string Id_ { get; set; }

        /// <summary>
        /// Year the user finished to study
        /// </summary>
        [JsonProperty("year_to")]
        public int? YearTo { get; set; }

        /// <summary>
        /// Graduation year
        /// </summary>
        [JsonProperty("year_graduated")]
        public int? YearGraduated { get; set; }

        /// <summary>
        /// School class letter
        /// </summary>
        [JsonProperty("class")]
        public string Class_ { get; set; }

        /// <summary>
        /// School type name
        /// </summary>
        [JsonProperty("type_str")]
        public string TypeStr { get; set; }

        /// <summary>
        /// Year the user started to study
        /// </summary>
        [JsonProperty("year_from")]
        public int? YearFrom { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("city")]
        public int? City_ { get; set; }

    }
}
