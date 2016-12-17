using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class LinkApplication
    {
        /// <summary>
        /// Application Id
        /// </summary>
        [JsonProperty("app_id")]
        public uint? AppId { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("store")]
        public LinkApplicationStore Store { get; set; }

    }
}
