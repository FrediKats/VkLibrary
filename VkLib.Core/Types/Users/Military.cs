using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class Military
    {
        /// <summary>
        /// Unit ID
        /// </summary>
        [JsonProperty("unit_id")]
        public int? UnitId { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        [JsonProperty("country_id")]
        public int? CountryId { get; set; }

        /// <summary>
        /// From year
        /// </summary>
        [JsonProperty("from")]
        public int? From_ { get; set; }

        /// <summary>
        /// Till year
        /// </summary>
        [JsonProperty("until")]
        public int? Until_ { get; set; }

        /// <summary>
        /// Unit name
        /// </summary>
        [JsonProperty("unit")]
        public string Unit_ { get; set; }

    }
}
