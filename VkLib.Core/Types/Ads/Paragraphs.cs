using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Ads 
{
    public class Paragraphs
    {
        /// <summary>
        /// Rules paragraph
        /// </summary>
        [JsonProperty("paragraph")]
        public string Paragraph { get; set; }

    }
}
