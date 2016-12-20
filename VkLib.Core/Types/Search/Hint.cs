using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Search 
{
    public class Hint
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("profile")]
        public VkLib.Types.Users.UserMin Profile { get; set; }

        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Object description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information whether the object has been found globally
        /// </summary>
        [JsonProperty("global")]
        public int? Global { get; set; }

        /// <summary>
        /// Section title
        /// </summary>
        [JsonProperty("section")]
        public string Section { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group")]
        public VkLib.Types.Groups.Group Group { get; set; }

    }
}
