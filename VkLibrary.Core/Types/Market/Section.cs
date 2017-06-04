using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Market
{
    public class Section
    {
        /// <summary>
        /// Section ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Section name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}