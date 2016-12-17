using System;
using Newtonsoft.Json;

namespace VkLib.Types.Database 
{
    public class Street
    {
        /// <summary>
        /// Street ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Street title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
