using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
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