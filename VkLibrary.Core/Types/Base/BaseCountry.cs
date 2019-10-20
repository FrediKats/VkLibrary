using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseCountry
    {
        ///<summary>
        /// Country ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Country title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}