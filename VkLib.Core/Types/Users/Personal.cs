using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Users 
{
    public class Personal
    {
        /// <summary>
        /// User's personal priority in life
        /// </summary>
        [JsonProperty("life_main")]
        public int? LifeMain { get; set; }

        /// <summary>
        /// User's personal priority in people
        /// </summary>
        [JsonProperty("people_main")]
        public int? PeopleMain { get; set; }

        /// <summary>
        /// User's inspired by
        /// </summary>
        [JsonProperty("inspired_by")]
        public string InspiredBy { get; set; }

        /// <summary>
        /// User's views on smoking
        /// </summary>
        [JsonProperty("smoking")]
        public int? Smoking_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("langs")]
        public IEnumerable<string> Langs_ { get; set; }

        /// <summary>
        /// User's religion
        /// </summary>
        [JsonProperty("religion")]
        public string Religion_ { get; set; }

        /// <summary>
        /// User's views on alcohol
        /// </summary>
        [JsonProperty("alcohol")]
        public int? Alcohol_ { get; set; }

        /// <summary>
        /// User's political views
        /// </summary>
        [JsonProperty("political")]
        public int? Political_ { get; set; }

    }
}
