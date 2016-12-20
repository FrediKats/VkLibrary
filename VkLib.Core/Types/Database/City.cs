using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Database 
{
    public class City : VkLib.Types.Base.Object
    {
        /// <summary>
        /// Area title
        /// </summary>
        [JsonProperty("area")]
        public string Area_ { get; set; }

        /// <summary>
        /// Information whether the city is included in important cities list
        /// </summary>
        [JsonProperty("important")]
        public int? Important_ { get; set; }

        /// <summary>
        /// Region title
        /// </summary>
        [JsonProperty("region")]
        public string Region_ { get; set; }

    }
}
