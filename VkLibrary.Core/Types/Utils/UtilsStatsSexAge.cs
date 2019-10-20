using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class UtilsStatsSexAge
    {
        ///<summary>
        /// Age denotation
        ///</summary>
        [JsonProperty("age_range")]
        public String AgeRange { get; set; }

        ///<summary>
        ///  Views by female users
        ///</summary>
        [JsonProperty("female")]
        public int Female { get; set; }

        ///<summary>
        ///  Views by male users
        ///</summary>
        [JsonProperty("male")]
        public int Male { get; set; }
    }
}