using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Search 
{
    public class Hint
    {
        /// <summary>
        /// Information whether the object has been found globally
        /// </summary>
        [JsonProperty("global")]
        public int? Global_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("profile")]
        public VkLib.Types.Users.UserMin Profile_ { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("group")]
        public VkLib.Types.Groups.Group Group_ { get; set; }

        /// <summary>
        /// Section title
        /// </summary>
        [JsonProperty("section")]
        public string Section_ { get; set; }

        /// <summary>
        /// Object type
        /// </summary>
        [JsonProperty("type")]
        public string Type_ { get; set; }

        /// <summary>
        /// Object description
        /// </summary>
        [JsonProperty("description")]
        public string Description_ { get; set; }

    }
}
