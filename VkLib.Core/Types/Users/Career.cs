using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class Career
    {
        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        /// <summary>
        /// From year
        /// </summary>
        [JsonProperty("from")]
        public int? From { get; set; }

        /// <summary>
        /// Till year
        /// </summary>
        [JsonProperty("until")]
        public int? Until { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// City ID
        /// </summary>
        [JsonProperty("city_id")]
        public int? CityId { get; set; }

        /// <summary>
        /// Community ID
        /// </summary>
        [JsonProperty("group_id")]
        public int? GroupId { get; set; }

    }
}
