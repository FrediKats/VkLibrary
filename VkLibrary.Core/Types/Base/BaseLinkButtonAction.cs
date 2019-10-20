using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkLibrary.Core.Objects
{
    public class BaseLinkButtonAction
    {
        [JsonProperty("type")]
        public BaseLinkButtonActionType Type { get; set; }

        ///<summary>
        /// Action URL
        ///</summary>
        [JsonProperty("url")]
        public String Url { get; set; }
    }
}