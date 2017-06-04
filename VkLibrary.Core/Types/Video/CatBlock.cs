using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Video
{
    public class CatBlock
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<CatElement> Items { get; set; }

        /// <summary>
        /// Block ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Block name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Information whether the block can be hidden
        /// </summary>
        [JsonProperty("can_hide")]
        public int? CanHide { get; set; }

        /// <summary>
        /// Block type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }

        /// <summary>
        /// Type of view
        /// </summary>
        [JsonProperty("view")]
        public string View { get; set; }
    }
}