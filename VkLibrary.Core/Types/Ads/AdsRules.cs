using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class AdsRules
    {
        [JsonProperty("paragraphs")]
        public AdsParagraphs[] Paragraphs { get; set; }

        ///<summary>
        /// Comment
        ///</summary>
        [JsonProperty("title")]
        public String Title { get; set; }
    }
}