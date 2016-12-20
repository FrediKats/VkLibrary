using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class LinkApplication
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("store")]
        public VkLib.Types.Base.LinkApplicationStore Store { get; set; }

        /// <summary>
        /// Application Id
        /// </summary>
        [JsonProperty("app_id")]
        public uint? AppId { get; set; }

    }
}
