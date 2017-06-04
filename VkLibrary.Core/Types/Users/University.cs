using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    public class University
    {
        /// <summary>
        /// Faculty name
        /// </summary>
        [JsonProperty("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// University ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Chair name
        /// </summary>
        [JsonProperty("chair_name")]
        public string ChairName { get; set; }

        /// <summary>
        /// University name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Chair ID
        /// </summary>
        [JsonProperty("chair")]
        public int? Chair { get; set; }

        /// <summary>
        /// Education form
        /// </summary>
        [JsonProperty("education_form")]
        public string EducationForm { get; set; }

        /// <summary>
        /// Faculty ID
        /// </summary>
        [JsonProperty("faculty")]
        public int? Faculty { get; set; }

        /// <summary>
        /// Graduation year
        /// </summary>
        [JsonProperty("graduation")]
        public int? Graduation { get; set; }

        /// <summary>
        /// Education status
        /// </summary>
        [JsonProperty("education_status")]
        public string EducationStatus { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country")]
        public int? Country { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("city")]
        public int? City { get; set; }
    }
}