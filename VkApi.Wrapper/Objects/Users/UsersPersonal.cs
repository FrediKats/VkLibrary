using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersPersonal
    {
        ///<summary>
        /// User's views on alcohol
        ///</summary>
        [JsonProperty("alcohol")]
        public int Alcohol { get; set; }

        ///<summary>
        /// User's inspired by
        ///</summary>
        [JsonProperty("inspired_by")]
        public String InspiredBy { get; set; }
        [JsonProperty("langs")]
        public String[] Langs { get; set; }

        ///<summary>
        /// User's personal priority in life
        ///</summary>
        [JsonProperty("life_main")]
        public int LifeMain { get; set; }

        ///<summary>
        /// User's personal priority in people
        ///</summary>
        [JsonProperty("people_main")]
        public int PeopleMain { get; set; }

        ///<summary>
        /// User's political views
        ///</summary>
        [JsonProperty("political")]
        public int Political { get; set; }

        ///<summary>
        /// User's religion
        ///</summary>
        [JsonProperty("religion")]
        public String Religion { get; set; }

        ///<summary>
        /// User's religion id
        ///</summary>
        [JsonProperty("religion_id")]
        public int ReligionId { get; set; }

        ///<summary>
        /// User's views on smoking
        ///</summary>
        [JsonProperty("smoking")]
        public int Smoking { get; set; }
    }
}