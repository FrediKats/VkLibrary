using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class TargSuggestionsSchools
    {
        /// <summary>
        /// School type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// School ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// School title
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// City name
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// Full school title
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

    }
}
