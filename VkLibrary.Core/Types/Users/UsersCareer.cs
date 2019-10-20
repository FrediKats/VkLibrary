using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UsersCareer
    {
        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("city_id")]
        public int CityId { get; set; }

        ///<summary>
        /// Company name
        ///</summary>
        [JsonProperty("company")]
        public String Company { get; set; }

        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("country_id")]
        public int CountryId { get; set; }

        ///<summary>
        /// From year
        ///</summary>
        [JsonProperty("from")]
        public int From { get; set; }

        ///<summary>
        /// Community ID
        ///</summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        ///<summary>
        /// Career ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Position
        ///</summary>
        [JsonProperty("position")]
        public String Position { get; set; }

        ///<summary>
        /// Till year
        ///</summary>
        [JsonProperty("until")]
        public int Until { get; set; }
    }
}