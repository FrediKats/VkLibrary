using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class Military
    {
        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        /// <summary>
        /// Unit name
        /// </summary>
        [JsonProperty("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Unit ID
        /// </summary>
        [JsonProperty("unit_id")]
        public int? UnitId { get; set; }

        /// <summary>
        /// Till year
        /// </summary>
        [JsonProperty("until")]
        public int? Until { get; set; }

        /// <summary>
        /// From year
        /// </summary>
        [JsonProperty("from")]
        public int? From { get; set; }

    }
}
