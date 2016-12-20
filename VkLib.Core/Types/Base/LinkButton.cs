using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Base 
{
    public class LinkButton
    {
        /// <summary>
        /// Button action
        /// </summary>
        [JsonProperty("action")]
        public VkLib.Types.Base.LinkButtonAction Action { get; set; }

        /// <summary>
        /// Button title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

    }
}
