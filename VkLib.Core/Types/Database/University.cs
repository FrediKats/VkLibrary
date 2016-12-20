using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Database 
{
    public class University
    {
        /// <summary>
        /// University ID
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// University title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
