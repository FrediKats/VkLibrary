using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
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