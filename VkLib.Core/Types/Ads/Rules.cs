using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class Rules
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("paragraphs")]
        public IEnumerable<Paragraphs> Paragraphs { get; set; }

        /// <summary>
        /// Comment
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
