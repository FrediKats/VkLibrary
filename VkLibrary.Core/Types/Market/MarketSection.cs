using System;
using Newtonsoft.Json;

namespace VkApi.Wrapper.Types.Market
{
    public class MarketSection
    {
        ///<summary>
        /// Section ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Section name
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}