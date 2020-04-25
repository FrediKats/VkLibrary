using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersUniversity
    {
        ///<summary>
        /// Chair ID
        ///</summary>
        [JsonProperty("chair")]
        public int Chair { get; set; }

        ///<summary>
        /// Chair name
        ///</summary>
        [JsonProperty("chair_name")]
        public String ChairName { get; set; }

        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("city")]
        public int City { get; set; }

        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("country")]
        public int Country { get; set; }

        ///<summary>
        /// Education form
        ///</summary>
        [JsonProperty("education_form")]
        public String EducationForm { get; set; }

        ///<summary>
        /// Education status
        ///</summary>
        [JsonProperty("education_status")]
        public String EducationStatus { get; set; }

        ///<summary>
        /// Faculty ID
        ///</summary>
        [JsonProperty("faculty")]
        public int Faculty { get; set; }

        ///<summary>
        /// Faculty name
        ///</summary>
        [JsonProperty("faculty_name")]
        public String FacultyName { get; set; }

        ///<summary>
        /// Graduation year
        ///</summary>
        [JsonProperty("graduation")]
        public int Graduation { get; set; }

        ///<summary>
        /// University ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// University name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}