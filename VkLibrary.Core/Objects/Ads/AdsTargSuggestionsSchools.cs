using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class AdsTargSuggestionsSchools
    {
        ///<summary>
        /// Full school title
        ///</summary>
        [JsonProperty("desc")]
        public String Desc { get; set; }

        ///<summary>
        /// School ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// School title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }

        ///<summary>
        /// City name
        ///</summary>
        [JsonProperty("parent")]
        public String Parent { get; set; }
        [JsonProperty("type")]
        public AdsTargSuggestionsSchoolsType Type { get; set; }
    }
}