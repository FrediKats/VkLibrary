using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class University
    {
        /// <summary>
        /// Chair name
        /// </summary>
        [JsonProperty("chair_name")]
        public string ChairName { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country")]
        public int? Country_ { get; set; }

        /// <summary>
        /// University name
        /// </summary>
        [JsonProperty("name")]
        public string Name_ { get; set; }

        /// <summary>
        /// Faculty ID
        /// </summary>
        [JsonProperty("faculty")]
        public int? Faculty_ { get; set; }

        /// <summary>
        /// University ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id_ { get; set; }

        /// <summary>
        /// Education form
        /// </summary>
        [JsonProperty("education_form")]
        public string EducationForm { get; set; }

        /// <summary>
        /// Education status
        /// </summary>
        [JsonProperty("education_status")]
        public string EducationStatus { get; set; }

        /// <summary>
        /// Graduation year
        /// </summary>
        [JsonProperty("graduation")]
        public int? Graduation_ { get; set; }

        /// <summary>
        /// Faculty name
        /// </summary>
        [JsonProperty("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// Chair ID
        /// </summary>
        [JsonProperty("chair")]
        public int? Chair_ { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("city")]
        public int? City_ { get; set; }

    }
}
