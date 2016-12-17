using System;
using Newtonsoft.Json;

namespace VkLib.Types.Places 
{
    public class Types
    {
        /// <summary>
        /// Place type ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Place type title
        /// </summary>
        [JsonProperty("title")]
        public int? Title { get; set; }

        /// <summary>
        /// URL of the place's icon
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

    }
}
