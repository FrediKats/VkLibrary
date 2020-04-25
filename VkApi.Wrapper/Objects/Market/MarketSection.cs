using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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