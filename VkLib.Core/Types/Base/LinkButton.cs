using System;
using Newtonsoft.Json;

namespace VkLib.Types.Base 
{
    public class LinkButton
    {
        /// <summary>
        /// Button title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Button action
        /// </summary>
        [JsonProperty("action")]
        public LinkButtonAction Action { get; set; }

    }
}
