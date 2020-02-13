using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Ads
{
    public class AdsTargSuggestions
    {
        ///<summary>
        /// Object ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Object name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}