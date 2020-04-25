using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class AdsGetCategoriesResponse
    {
        ///<summary>
        /// Old categories
        ///</summary>
        [JsonProperty("v1")]
        public AdsCategory[] V1 { get; set; }

        ///<summary>
        /// Actual categories
        ///</summary>
        [JsonProperty("v2")]
        public AdsCategory[] V2 { get; set; }
    }
}