using System;
using Newtonsoft.Json;

namespace VkLib.Types.Search 
{
    public class Hint
    {
        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Section title
        /// </summary>
        [JsonProperty("section")]
        public string Section { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("profile")]
        public UserMin Profile { get; set; }

        /// <summary>
        /// Object description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information whether the object has been found globally
        /// </summary>
        [JsonProperty("global")]
        public BoolInt Global { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group")]
        public Group Group { get; set; }

    }
}
