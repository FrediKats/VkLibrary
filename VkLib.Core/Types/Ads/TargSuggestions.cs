using System;
using Newtonsoft.Json;

namespace VkLib.Types.Ads 
{
    public class TargSuggestions
    {
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Object name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
