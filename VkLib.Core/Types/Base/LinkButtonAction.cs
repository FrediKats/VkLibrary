using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class LinkButtonAction
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("type")]
        public LinkButtonActionType Type { get; set; }

        /// <summary>
        /// Action URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
