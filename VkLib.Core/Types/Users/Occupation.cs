using System;
using Newtonsoft.Json;

namespace VkLib.Types.Users 
{
    public class Occupation
    {
        /// <summary>
        /// Type of occupation
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// ID of school, university, company group
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of occupation
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
