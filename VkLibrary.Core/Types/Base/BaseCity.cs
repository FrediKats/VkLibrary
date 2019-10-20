using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseCity
    {
        ///<summary>
        /// City ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// City title
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}