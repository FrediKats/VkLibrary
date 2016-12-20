using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class RequestParam
    {
        /// <summary>
        /// Parameter name
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Parameter value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

    }
}
