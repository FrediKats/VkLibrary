using System;
using Newtonsoft.Json;

namespace VkLib.Types.Database 
{
    public class School
    {
        /// <summary>
        /// School ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// School title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
