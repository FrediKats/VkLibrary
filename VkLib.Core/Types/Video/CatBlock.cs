using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Video 
{
    public class CatBlock
    {
        /// <summary>
        /// Block name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// New value for _from_ parameter
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }

        /// <summary>
        /// Block ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Block type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Information whether the block can be hidden
        /// </summary>
        [JsonProperty("can_hide")]
        public int? CanHide_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<VkLib.Types.Video.CatElement> Items { get; set; }

        /// <summary>
        /// Type of view
        /// </summary>
        [JsonProperty("view")]
        public string View { get; set; }

    }
}
