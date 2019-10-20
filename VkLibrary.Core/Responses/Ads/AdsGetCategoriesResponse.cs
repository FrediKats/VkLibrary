using Newtonsoft.Json;
using VkLibrary.Core.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkLibrary.Core.Responses
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