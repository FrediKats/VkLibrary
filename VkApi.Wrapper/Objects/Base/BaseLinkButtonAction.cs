using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
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
        [JsonProperty("consume_reason")]
        public String ConsumeReason { get; set; }
    }
}