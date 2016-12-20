using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Rules
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("paragraphs")]
        public IEnumerable<VkLib.Types.Ads.Paragraphs> Paragraphs { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
