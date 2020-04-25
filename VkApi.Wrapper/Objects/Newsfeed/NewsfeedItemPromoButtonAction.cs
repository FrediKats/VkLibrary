using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedItemPromoButtonAction
    {
        [JsonProperty("url")]
        public String Url { get; set; }
        [JsonProperty("type")]
        public String Type { get; set; }
        [JsonProperty("target")]
        public String Target { get; set; }
    }
}