using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class LinkApplicationStore
    {
        /// <summary>
        /// Store name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Store Id
        /// </summary>
        [JsonProperty("id")]
        public uint? Id { get; set; }

    }
}
