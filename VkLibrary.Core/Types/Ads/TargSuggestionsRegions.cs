using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    public class TargSuggestionsRegions
    {
        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

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