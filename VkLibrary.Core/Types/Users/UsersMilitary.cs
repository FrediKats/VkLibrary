using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Users
{
    public class UsersMilitary
    {
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
        /// Military ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Unit name
        ///</summary>
        [JsonProperty("unit")]
        public String Unit { get; set; }

        ///<summary>
        /// Unit ID
        ///</summary>
        [JsonProperty("unit_id")]
        public int UnitId { get; set; }

        ///<summary>
        /// Till year
        ///</summary>
        [JsonProperty("until")]
        public int Until { get; set; }
    }
}