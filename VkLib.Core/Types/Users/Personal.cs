using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class Personal
    {
        /// <summary>
        /// User's inspired by
        /// </summary>
        [JsonProperty("inspired_by")]
        public string InspiredBy { get; set; }

        /// <summary>
        /// User's political views
        /// </summary>
        [JsonProperty("political")]
        public int? Political { get; set; }

        /// <summary>
        /// User's views on alcohol
        /// </summary>
        [JsonProperty("alcohol")]
        public int? Alcohol { get; set; }

        /// <summary>
        /// User's personal priority in life
        /// </summary>
        [JsonProperty("life_main")]
        public int? LifeMain { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("langs")]
        public IEnumerable<string> Langs { get; set; }

        /// <summary>
        /// User's religion
        /// </summary>
        [JsonProperty("religion")]
        public string Religion { get; set; }

        /// <summary>
        /// User's views on smoking
        /// </summary>
        [JsonProperty("smoking")]
        public int? Smoking { get; set; }

        /// <summary>
        /// User's personal priority in people
        /// </summary>
        [JsonProperty("people_main")]
        public int? PeopleMain { get; set; }

    }
}
